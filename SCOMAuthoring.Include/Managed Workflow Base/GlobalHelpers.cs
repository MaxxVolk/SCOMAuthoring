// .Net Framework
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;
using Microsoft.EnterpriseManagement.Modules.DataItems.Discovery;
using Microsoft.EnterpriseManagement.Mom.Modules.DataItems;

namespace SCOMAuthoringBook.Library
{
  public enum EventLoggingLevel { None = 0, Error = 1, Warning = 2, Informational = 3, Verbose = 4 }

  public enum BinaryPrefix { Byte = 0, KiloByte = 1, MegaByte = 2, GigaByte = 3, TeraByte = 4, PetaByte = 5, ExaByte = 6, ZettaByte = 7, YottaByte = 8 }

  public class Global
  {
    // internal fields
    private static string _eventSourceName = "";
    private static Dictionary<Type, int> _eventTypeIDs = new Dictionary<Type, int>();
    private static object _eventTypeIDs_lock = new object();
    private static string DebugLogFolderPath = Environment.GetEnvironmentVariable("windir") + "\\debug";

    // public properties
    public static string eventSourceName
    {
      get { return _eventSourceName; }
      set
      {
        if (_eventSourceName != value)
        {
          _eventSourceName = value;
          RegisterEventSource(value);
        }
      }
    }

    public static void AddLoggingSource(Type classType, int incrementalID)
    {
      lock (_eventTypeIDs_lock)
      {
        if (!_eventTypeIDs.ContainsKey(classType))
        {
          _eventTypeIDs.Add(classType, eventBaseID + incrementalID);
        }
      }
    }

    public static int eventBaseID { get; set; }
    public static EventLoggingLevel eventLoggingLevel { get; set; } = EventLoggingLevel.Verbose;

    private static void RegisterEventSource(string SourceName)
    {
#if (!DEBUG) // release only
      if (!EventLog.SourceExists(SourceName))
      {
        var sourceInfo = new EventSourceCreationData(SourceName, "Operations Manager");
        EventLog.CreateEventSource(sourceInfo);
      }
#endif
    }

    public static void logWriteVerbose(string debugInfo, string component, string source, int debugSeverity)
    {
      if (eventLoggingLevel < EventLoggingLevel.Verbose) // a bit of optimization
        return;
      logWriteVerbose(DebugLogFolderPath, debugInfo, component, source, debugSeverity);
    }

    // private static Queue<string> debugInfoBuffer = new Queue<string>();

    public static void logWriteVerbose(string logFilePath, string debugInfo, string component, string source, int debugSeverity)
    {
      if (eventLoggingLevel < EventLoggingLevel.Verbose)
        return;
      DateTime localNow = DateTime.Now;
      DateTime utcNow = DateTime.UtcNow;
      int UTCOffset = (int)Math.Truncate(utcNow.Subtract(localNow).TotalMinutes);
      string strUTCOffset;
      if (UTCOffset < 0)
        strUTCOffset = UTCOffset.ToString("D");
      else
        strUTCOffset = "+" + UTCOffset.ToString("D");
      string formattedMessage = "<![LOG[" + debugInfo + "]LOG]!>";
      // time="17:23:36.867-720" date="04-20-2016"
      string strTime = "time=\"" + localNow.ToString("HH:mm:ss.fff") + strUTCOffset + "\"";
      string strDate = "date=\"" + localNow.ToString("MM-dd-yyyy") + "\"";
      string strLogFileName = logFilePath + "\\" + _eventSourceName + "-" + localNow.ToString("yyyy-MM-dd") + ".log";
      formattedMessage += "<" + strTime + " " + strDate + " component=\"" + component +
        "\" context=\"\" type=\"1\" thread=\"" + debugSeverity.ToString() + "\" file=\"" + source + "\">" + "\r\n";
      // need that due to multi-threading nature
      for (var attemptCounter = 0; attemptCounter < 10; attemptCounter++)
      {
        try
        {
          File.AppendAllText(strLogFileName, formattedMessage);
          break; // exit the loop if the write op is successful
        }
        catch (Exception)
        {
          Thread.Sleep(10); // wait a bit and repeat
        }
      }
    }

    public static void logWriteInformation(string message, object Src, params object[] stringFormatArgs)
    {
#if DEBUG // using only text file logging in DEBUG release
      logWriteVerbose(message, "", "", 0);
#else
      if (eventLoggingLevel >= EventLoggingLevel.Informational)
        logWriteEvent(message, EventLogEntryType.Information, Src, stringFormatArgs);
#endif
    }
    public static void logWriteWarning(string message, object Src, params object[] stringFormatArgs)
    {
#if DEBUG // using only text file logging in DEBUG release
      logWriteVerbose(message, "", "", 1);
#else
      if (eventLoggingLevel >= EventLoggingLevel.Warning)
        logWriteEvent(message, EventLogEntryType.Warning, Src, stringFormatArgs);
#endif
    }
    public static void logWriteError(string message, object Src, params object[] stringFormatArgs)
    {
#if DEBUG // using only text file logging in DEBUG release
      logWriteVerbose(message, "", "", 2);
#else
      if (eventLoggingLevel >= EventLoggingLevel.Error)
        logWriteEvent(message, EventLogEntryType.Error, Src, stringFormatArgs);
#endif
    }

    public static void logWriteException(string message, Exception e, object Src, params object[] stringFormatArgs)
    {
      string exceptionDescription = "";
      exceptionDescription += "Exception in " + (Src?.GetType()?.Name ?? "N/A") + ".\r\n";
      exceptionDescription += "Message: " + (message ?? "<NULL message>") + "\r\n\r\n";
      exceptionDescription += "Exceptions:\r\n";
      Exception loopException = e;
      int ordernum = 1;
      do
      {
        exceptionDescription += ordernum.ToString() + "): Exception type: " + loopException.GetType().Namespace + "." + loopException.GetType().Name + "\r\n";
        exceptionDescription += loopException.GetType().FullName + " exception (" + loopException.Message + ")";
        exceptionDescription += loopException.StackTrace + "\r\n\r\n";
        loopException = loopException.InnerException;
        ordernum++;
      } while (loopException != null);
      logWriteError(exceptionDescription, Src, stringFormatArgs);
    }

    public static void logWriteException(Exception e, object Src, params object[] stringFormatArgs)
    {
      StackTrace stackTrace = new StackTrace();
      var callingMethod = stackTrace.GetFrame(1).GetMethod();
      string message = "Generic exception in the " + callingMethod.Name +
        " method of the " + callingMethod.DeclaringType.Name + " class.";
      logWriteException(message, e, Src, stringFormatArgs);
    }

    private static int _cachedPID = -1;
    private static void logWriteEvent(string message, EventLogEntryType type, object Src, params object[] formatArgs)
    {
      // it's not referenced in DEBUG release
      try
      {
        if (formatArgs != null && formatArgs.Length > 0)
          message = string.Format(message, formatArgs);
        if (_cachedPID == -1)
          _cachedPID = Process.GetCurrentProcess().Id;
        else
          message += "\r\n\r\nCurrent Process Id (PID): " + _cachedPID.ToString();
        if (Src == null)
          EventLog.WriteEntry(_eventSourceName, message, type, eventBaseID);
        else if (Src.GetType() == typeof(Type))
          EventLog.WriteEntry(_eventSourceName, message, type, logEventIdFromSource((Type)Src));
        else
        {
          try
          {
            Type srcType = Src.GetType();
            PropertyInfo moduleNamePropertyInfo = srcType.GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            string moduleNameValue = "<ModuleName peoperty is not defined>";
            if (moduleNamePropertyInfo != null)
              moduleNameValue = NullToEmptyString(moduleNamePropertyInfo.GetValue(Src, null));
            else
              moduleNameValue = Src.GetType().FullName;
            PropertyInfo moduleVersionPropertyInfo = srcType.GetProperty("ModuleVersion", BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            string moduleVersionValue = "<ModuleVersion peoperty is not defined>";
            if (moduleVersionPropertyInfo != null)
              moduleVersionValue = NullToEmptyString(moduleVersionPropertyInfo.GetValue(Src, null));
            message += "\r\n\r\nModule: " + moduleNameValue + "\r\nVersion: " + moduleVersionValue;
          }
          catch { message += "\r\n\r\nModule: <not available>\r\nVersion: <not available>"; } // do nothing
          EventLog.WriteEntry(_eventSourceName, message, type, logEventIdFromSource(Src.GetType()));
        }
      }
      catch (Exception e)
      {
        // shall fail to file logging if any issues with Event Log
        if (Src != null)
          logWriteVerbose(message + "\r\n" + e.Message, Src.GetType().Name, "", (int)type);
        else
          logWriteVerbose(message + "\r\n" + e.Message, "", "", (int)type);
      }
    }

    private static int logEventIdFromSource(Type src)
    {
      lock (_eventTypeIDs_lock)
      {
        if (_eventTypeIDs.ContainsKey(src))
          return _eventTypeIDs[src];
        else
          return eventBaseID;
      }
    }

    static public string TruncateFromBeginning(string InputParam, int charLimit)
    {
      if (charLimit >= InputParam.Length)
        return InputParam;
      else
        return "..." + InputParam.Substring(InputParam.Length - charLimit + 3);
    }

    /// <summary>
    /// Translate a wildcard sting to a regular expression one.
    /// </summary>
    /// <param name="pattern">Wildcard expression to translate</param>
    /// <returns>Regular expression equivalent of the given wildcard one</returns>
    public static string WildcardToRegex(string pattern, bool fixedStart = true, bool fixedEnd = true)
    {
      return (fixedStart ? "^" : "") + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + (fixedEnd ? "$" : "");
    }

    /// <summary>
    /// Truncate input string to given length.
    /// </summary>
    /// <param name="InputParam">Original string</param>
    /// <param name="charLimit">String size limit (default 255)</param>
    /// <returns>Limited size string</returns>
    public static string TruncateAt(string InputParam, int charLimit = 255)
    {
      if (InputParam.Length <= charLimit)
        return InputParam;
      else
        return InputParam.Substring(0, charLimit);
    }

    /// <summary>
    /// Treat a null string as an empty one.
    /// </summary>
    /// <param name="InputParam"></param>
    /// <returns>The original string if not null or zero-length not null string</returns>
    public static string NullToEmptyString(string InputParam)
    {
      if (string.IsNullOrEmpty(InputParam))
        return "";
      else
        return InputParam;
    }

    /// <summary>
    /// Translate an object to string if not null, or return an empty string.
    /// </summary>
    /// <param name="InputParam"></param>
    /// <returns>String representation of an object, even if null</returns>
    public static string NullToEmptyString(object InputParam)
    {
      if (InputParam == null)
        return "";
      else
        return InputParam.ToString();
    }

    /// <summary>
    /// Test input string against wildcard pattern.
    /// </summary>
    /// <param name="test">Source string</param>
    /// <param name="pattern">Wildcard pattern</param>
    /// <returns>true if source matches wildcard</returns>
    public static bool MatchWildcard(string test, string pattern)
    {
      return Regex.IsMatch(test, WildcardToRegex(pattern), RegexOptions.IgnoreCase | RegexOptions.Singleline);
    }

    // MOVED to ModuleBaseWithServiceFunctions<DataItemBase>
    //public static bool ConvertSCOMBoolean(string BoolString)
    //{
    //  bool _Result;
    //  _Result = false;
    //  if (!string.IsNullOrEmpty(BoolString))
    //  { _Result = string.Equals(BoolString, "true", StringComparison.OrdinalIgnoreCase) | string.Equals(BoolString, "1", StringComparison.OrdinalIgnoreCase); }
    //  return _Result;
    //}

    //public static string ConvertToSCOMBoolean(bool? inputValue)
    //{
    //  if (inputValue == null)
    //    return "false";
    //  else
    //  {
    //    if (inputValue == true)
    //      return "true";
    //    else
    //      return "false";
    //  }
    //}

    public static PropertyBagDataItem CreatePropertyBag(Dictionary<string, object> bagItem)
    {
      Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>();
      dictionary.Add("", bagItem);
      return new PropertyBagDataItem(null, dictionary);
    }

    private static string[] decimalPrefixNames = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
    private static string[] binaryPrefixNames = { "B", "KiB", "MiB", "GiB", "TiB", "PiB", "EiB", "ZiB", "YiB" };

    /// <summary>
    /// Convert byte count for human readable display value, by auto-choosing the best unit.
    /// </summary>
    /// <param name="bytes">Original number by bytes.</param>
    /// <param name="prcisionDigits">Number of decimal fraction digits in output.</param>
    /// <param name="useDecimalPrefixes">Chose between decimal (kilo/KB) or binary (kibi/KiB) prefixes. The actual divider is ALWAYS 1024 regardless the prefix.</param>
    /// <returns>Formatted string.</returns>
    public static string FormatBytes1024(long bytesCount, int prcisionDigits = 2, bool useDecimalPrefixes = true)
    {
      decimal bytes = bytesCount;
      return FormatBytes1024(bytes, prcisionDigits, useDecimalPrefixes);
    }

    /// <summary>
    /// Convert byte count for human readable display value, by auto-choosing the best unit.
    /// </summary>
    /// <param name="bytes">Original number by bytes.</param>
    /// <param name="prcisionDigits">Number of decimal fraction digits in output.</param>
    /// <param name="useDecimalPrefixes">Chose between decimal (kilo/KB) or binary (kibi/KiB) prefixes. The actual divider is ALWAYS 1024 regardless the prefix.</param>
    /// <returns>Formatted string.</returns>
    public static string FormatBytes1024(decimal bytes, int prcisionDigits = 2, bool useDecimalPrefixes = true)
    {
      int magnifierCounter = 0;
      do
      {
        if (bytes < 1024)
          return bytes.ToString($"N{prcisionDigits}") + " " + (useDecimalPrefixes ? decimalPrefixNames[magnifierCounter] : binaryPrefixNames[magnifierCounter]);
        bytes = bytes / 1024;
        magnifierCounter++;
      } while (magnifierCounter < decimalPrefixNames.Length);
      return (bytes * 1024).ToString($"N{prcisionDigits}") + " " + (useDecimalPrefixes ? decimalPrefixNames[magnifierCounter - 1] : binaryPrefixNames[magnifierCounter - 1]);
    }

    public static double ConvertBytes1024(decimal fromBytes, BinaryPrefix fromUnit, BinaryPrefix toUnit)
    {
      int magnifierCounter = fromUnit - toUnit;
      if (magnifierCounter == 0)
        return Convert.ToDouble(fromBytes);
      if (magnifierCounter > 0)
      {
        for (int idx = 0; idx < magnifierCounter; idx++)
          fromBytes = fromBytes * 1024;
        return Convert.ToDouble(fromBytes);
      }
      if (magnifierCounter < 0)
      {
        for (int idx = 0; idx < -magnifierCounter; idx++)
          fromBytes = fromBytes / 1024;
        return Convert.ToDouble(fromBytes);
      }
      throw new Exception("You just did the impossible!");
    }
  }

}
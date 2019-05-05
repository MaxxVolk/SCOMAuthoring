// .Net Framework
using System;
using System.Xml;
using System.Xml.Serialization;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  [Serializable]
  public class Bookmarks
  {
    public long longBookmark;
    public DateTime timeBookmark;
    public double doubleBookmark;
  }

  public class DataItemRawXML : DataItemBase
  {
    private readonly string dataItemTypeName = "Revera.Library.RawXMLData";
    private readonly string wholeXML;

    public DataItemRawXML(XmlReader reader) : base(reader)
    {
      wholeXML = reader.ReadOuterXml();
    }

    public DataItemRawXML(string CustomDataItemTypeName, XmlReader reader) : base(reader)
    {
      string currentElement;
      do
      {
        currentElement = reader.ReadOuterXml();
        wholeXML += currentElement;
      } while (!string.IsNullOrEmpty(currentElement));

      dataItemTypeName = CustomDataItemTypeName;
    }

    public override string DataItemTypeName => dataItemTypeName;

    protected override void GenerateItemXml(XmlWriter writer) => writer.WriteRaw(wholeXML);
  }

  #region Serialization Data Item Base
  public abstract class SerializationData
  {
    public SerializationData()
    {
      var xmlArrtibute = GetType().GetCustomAttributes(typeof(XmlRootAttribute), true);
      if (xmlArrtibute == null || xmlArrtibute.Length != 1)
        throw new InvalidCastException("Types inherited from SerializationData must have XmlRoot attribute.");
    }
  }

  public abstract class SerializationDataContainerDataItemBase<T> : DataItemBase where T : SerializationData
  {
    public T Data { get; }

    public SerializationDataContainerDataItemBase(T data)
    {
      Data = data;
    }

    public SerializationDataContainerDataItemBase(XmlReader reader) : base(reader)
    {
      XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
      Data = (T)xmlFormat.Deserialize(reader);
    }

    protected abstract string GetDataItemTypeName();

    public override string DataItemTypeName
    {
      get
      {
        return GetDataItemTypeName();
      }
    }

    protected override void GenerateItemXml(XmlWriter writer)
    {
      XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
      xmlFormat.Serialize(writer, Data);
    }
  }
  #endregion
}

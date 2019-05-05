using System;

namespace SCOMAuthoringBook.Library.Editor
{
  [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
  sealed class SCOMClassPropertyAttribute : Attribute
  {

    // This is a positional argument
    public SCOMClassPropertyAttribute(string propertyGuid) => PropertyId = Guid.Parse(propertyGuid);

    public Guid PropertyId { get; }
  }
}

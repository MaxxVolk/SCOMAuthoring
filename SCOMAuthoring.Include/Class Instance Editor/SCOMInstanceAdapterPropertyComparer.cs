using System;
using System.ComponentModel;

namespace SCOMAuthoringBook.Library.Editor
{
  public class SCOMInstanceAdapterPropertyComparer<A> where A : SCOMClassInstanceAdapter
  {
    private PropertyDescriptor sortingProperty;
    public SCOMInstanceAdapterPropertyComparer(PropertyDescriptor property)
    {
      sortingProperty = property;
    }

    public int Compare(A instance, object value)
    {
      object instanceValue = sortingProperty.GetValue(instance);
      if (value is null && instanceValue is null)
        return 0;
      if (value is null || instanceValue is null)
        return -1;
      if (sortingProperty.Name == "BindableActionPoint" || sortingProperty.Name == "ActionPoint")
      {
        string DisplayName = null;
        DisplayName = instance?.ActionPoint?.DisplayName;
        if (DisplayName is null && value is null)
          return 0;
        if (DisplayName is null || value is null)
          return -1;
        return ((IComparable)DisplayName).CompareTo(value);
      }
      else
        return ((IComparable)instanceValue).CompareTo(value);
    }
  }
}

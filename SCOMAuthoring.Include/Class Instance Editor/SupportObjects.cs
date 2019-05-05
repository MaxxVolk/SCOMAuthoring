using System;
using System.Collections.Generic;
using Microsoft.EnterpriseManagement.Monitoring;
using System.Runtime.Serialization;

namespace SCOMAuthoringBook.Library.Editor
{
  public delegate void ObjectChangedEventHandler(object sender, ObjectChangedEventArgs e);

  public class ObjectChangedEventArgs : EventArgs
  {
    public ObjectChangedEventArgs(InstanceCommitStatus CommitStatus) : base ()
    {
      this.CommitStatus = CommitStatus;
    }

    public InstanceCommitStatus CommitStatus { get; set; }
  }

  [Serializable]
  public class SCOMClassInstanceEditorException : Exception
  {
    public SCOMClassInstanceEditorException() : base() { }

    public SCOMClassInstanceEditorException(string Message) : base(Message) { }

    public SCOMClassInstanceEditorException(string message, Exception innerException) : base(message, innerException) { }

    protected SCOMClassInstanceEditorException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }

  public class SCOMClassInstanceCommintStatusException : Exception
  {
    public SCOMClassInstanceCommintStatusException() : base() { }

    public SCOMClassInstanceCommintStatusException(string Message) : base(Message) { }

    public SCOMClassInstanceCommintStatusException(string message, Exception innerException) : base(message, innerException) { }

    protected SCOMClassInstanceCommintStatusException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }
}
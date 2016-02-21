using System;
using System.Runtime.Serialization;

[Serializable]
internal class InventroyFullException : Exception
{
    public InventroyFullException()
    {
    }

    public InventroyFullException(string message) : base(message)
    {
    }

    public InventroyFullException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InventroyFullException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
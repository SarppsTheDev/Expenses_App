using System.Runtime.Serialization;

namespace expenses_core.CustomExceptions;

public class InvalidUsernamePasswordException : Exception
{
    public InvalidUsernamePasswordException()
    {
    }

    protected InvalidUsernamePasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public InvalidUsernamePasswordException(string? message) : base(message)
    {
    }

    public InvalidUsernamePasswordException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
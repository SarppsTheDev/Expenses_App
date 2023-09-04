using System.Runtime.Serialization;

namespace expenses_core.CustomExceptions;

public class UsernameAlreadyExistsException : Exception
{
    public UsernameAlreadyExistsException()
    {
    }

    protected UsernameAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public UsernameAlreadyExistsException(string? message) : base(message)
    {
    }

    public UsernameAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
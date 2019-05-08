using System;

namespace Araye.Code.Cqrs.Application.Exceptions
{
    public class AppException : Exception
    {
        public AppException(string message)
            : base($"An error occured: {message}")
        {
        }
    }
}

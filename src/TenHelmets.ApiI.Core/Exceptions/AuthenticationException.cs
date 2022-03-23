using System;

namespace TenHelmets.API.Core.Exceptions
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException(string msg) : base(msg)
        {
        }

        public AuthenticationException(string msg, Exception cause) : base(msg, cause)
        {
        }
    }
}

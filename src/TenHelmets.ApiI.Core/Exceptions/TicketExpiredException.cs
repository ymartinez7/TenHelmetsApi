using System;

namespace TenHelmets.API.Core.Exceptions
{
    public class TicketExpiredException : AuthenticationException
    {
        public TicketExpiredException(string msg) : base(msg)
        {
        }

        public TicketExpiredException(string msg, Exception cause) : base(msg, cause)
        {
        }
    }
}

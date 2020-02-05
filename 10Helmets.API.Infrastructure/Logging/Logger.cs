namespace _10Helmets.API.Infrastructure.Logging
{
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static  class Logger
    {
        public static void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

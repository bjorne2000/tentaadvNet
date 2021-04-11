using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendHamster.Operations
{
    public class rapport
    {
        
        public static Task ConsoleLog( string message)
        {
             Console.WriteLine(message);
            return Task.CompletedTask;
        }

    }
}

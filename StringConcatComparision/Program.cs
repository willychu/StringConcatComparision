using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringConcatComparision
{
    class Program
    {
        private const int ConcatCount = 300000;

        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            //=================================================================//

            //-------------------------
            // Case 1: String
            //-------------------------

            var mode = "String";
            var str = string.Empty;
            for (int i = 0; i < ConcatCount; i++)
            {
                str += ".";
            }

            //-------------------------
            // Case 2: StringBuilder
            //-------------------------
            
            // var mode = "StringBuilder";
            // var sb = new StringBuilder();
            // for (int i = 0; i < ConcatCount; i++)
            // {
            //     sb.Append(".");
            // }

            //=================================================================//

            stopWatch.Stop();
            
            var ts = stopWatch.Elapsed;

            Console.WriteLine($"Mode: {mode}");
            Console.WriteLine($"RunTime: {ts.TotalMilliseconds} ms");
        }
    }
}

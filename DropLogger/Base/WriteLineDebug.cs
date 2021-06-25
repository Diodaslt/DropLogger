using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    /// <summary>
    /// Static class that return a console message with a time stamp
    /// </summary>
    public static class WriteLineDebug
    {
        static WriteLineDebug()
        {

        }

        /// <summary>
        /// Write the log message
        /// </summary>
        /// <param name="message">Message passed in</param>
        public static void Write(string message)
        {
            Debug.WriteLine("{0} - {1}", DateTime.Now.ToString("HH:mm:ss.FF"), message);
        }
    }
}

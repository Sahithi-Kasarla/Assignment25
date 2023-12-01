using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class MyUtilityClass
    {
        public static bool IsDataValid(string data)
        {
            // Add your data validation logic here
            return !string.IsNullOrEmpty(data);
        }

        public static void LogMessage(string message)
        {
            // Add your logging logic here
            Console.WriteLine($"Log: {message}");
        }
    }
}

using System;
using System.Globalization;

namespace FuncaoStringChallenge
{
    class Program
    {
        public static string StringChallenge(string str)
        {
            // code goes here  
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}

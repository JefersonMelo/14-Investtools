using System;

namespace FuncaoMathChallenge
{
    class Program
    {
        public static bool MathChallenge(int num)
        {
            // code goes here  
            int cont = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) cont++;
            }
            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(MathChallenge(Console.ReadLine()));
        }
    }
}

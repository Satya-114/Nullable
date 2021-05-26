using System;

namespace Nullables_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int? val1 = 4;
            int? val2 = null;
            bool? val3 = true;
            bool? val4 = null;
            char? val5 = 'a';
            char? val6 = null;
            Console.WriteLine("Value of val1: {0}", val1);
            Console.WriteLine("Value of val2: {0}", val2);
            Console.WriteLine("Value of val3: {0}", val3);
            Console.WriteLine("Value of val4: {0}", val4);
            Console.WriteLine("Value of val5: {0}", val5);
            Console.WriteLine("Value of val6: {0}", val6);
        }
    }
}

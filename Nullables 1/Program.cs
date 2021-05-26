using System;

namespace Nullable_type_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = a ?? 3;
            Console.WriteLine(b);
        }
    }
}

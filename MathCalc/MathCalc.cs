using System;
using SwitchCase;

namespace MathCalc
{
    class MathCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the value of variables");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Logic.DoMethod(a,b);
        }
    }
}

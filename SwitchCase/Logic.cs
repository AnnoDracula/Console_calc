using System;
using System.Diagnostics;
using MethodsLibrary;

namespace SwitchCase
{
    public static class Logic
    {
        public static void DoMethod(int a, int b)
        {
            int caseSwitch;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select a mathematical operation:");
                Console.WriteLine("1 -> (+); 2 -> (-); 3 -> (*); 4 -> (/)");
                Console.WriteLine("Write (0) to close programm");
                caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("a + b = " + MathMethods.Summ(a, b));
                        break;
                    case 2:
                        Console.WriteLine("a - b = " + MathMethods.Diff(a, b));
                        break;
                    case 3:
                        Console.WriteLine("a * b = " + MathMethods.Multiplication(a, b));
                        break;
                    case 4:
                        Console.WriteLine("a / b = " + MathMethods.Division(a, b));
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Operation does't exist");
                        break;
                }
            } while (caseSwitch != 0);
        }
    }
}


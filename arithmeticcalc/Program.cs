using System;

namespace arithmeticcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the action to be performed");
            Console.WriteLine("1-Addition 2-Subtraction 3-Multiplication 4-Division");
            int operation = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            var num2 = Convert.ToDecimal(Console.ReadLine());
            decimal result = 0;
            switch (operation)
            {
                case 1:
                    {
                        result = (num1 + num2);
                        break;
                    }
                case 2:
                    {
                        result = (num1 - num2);
                        break;
                    }
                case 3:
                    {
                        result = (num1 * num2);
                        break;
                    }
                case 4:
                    {
                        result = (num1 / num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Selection");
                        break;
                    }
            }
            Console.WriteLine("Result = {0} ", result);
        }
    }
}

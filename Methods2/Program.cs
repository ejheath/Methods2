using System;

namespace Methods2
{
    class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine(Add(7, 5));

            Console.WriteLine("this is the sum");

            Console.WriteLine(Subtract(5679876, 926));

            Console.WriteLine("this is the difference");

            Console.WriteLine(Multiply(12, 9));
            Console.WriteLine("this is the product");

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}


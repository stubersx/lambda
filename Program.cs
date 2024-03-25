using System.Diagnostics.CodeAnalysis;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = double.Parse(Console.ReadLine());
            var sum = (double x, double y) => x + y;
            var multi = (double x, double y) => x * y;
            var min = (double x, double y) =>
            {
                if(x > y)
                    return y;
                else
                    return x;
            };
            Console.WriteLine($"The sum is: {sum(num1, num2)}");
            Console.WriteLine($"The multiple is: {multi(num1, num2)}");
            Console.WriteLine($"The smaller value is: {min(num1, num2)}");
        }
    }
}

using System.Transactions;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparision");
            float x1;
            float x2;
            float y1;
            float y2;
            float length;
            Console.WriteLine("enter the x1 value");
            float.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine("enter the x2 value");
            float.TryParse(Console.ReadLine(), out x2);
            Console.WriteLine("enter the y1 value");
            float.TryParse(Console.ReadLine(), out y1);
            Console.WriteLine("enter the y2 value");
            float.TryParse(Console.ReadLine(), out y2);
            length = (float) Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length of co-ordinates is");
            Console.WriteLine(length);
              
        }
    }
}
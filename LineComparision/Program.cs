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
            float x3;
            float x4;
            float y3;
            float y4;
            float length1;
            float length2;
            Console.WriteLine("enter the x1 value");
            float.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine("enter the x2 value");
            float.TryParse(Console.ReadLine(), out x2);
            Console.WriteLine("enter the y1 value");
            float.TryParse(Console.ReadLine(), out y1);
            Console.WriteLine("enter the y2 value");
            float.TryParse(Console.ReadLine(), out y2);
            Console.WriteLine("enter the x3 value");
            float.TryParse(Console.ReadLine(), out x3);
            Console.WriteLine("enter the x4 value");
            float.TryParse(Console.ReadLine(), out x4);
            Console.WriteLine("enter the y3 value");
            float.TryParse(Console.ReadLine(), out y3);
            Console.WriteLine("enter the y4 value");
            float.TryParse(Console.ReadLine(),out y4);

            length1 = (float) Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2));
            length2 = (float)Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("length of first co-ordinates  is");
            Console.WriteLine(length1);
            Console.WriteLine("length of second co-ordinates  is");
            Console.WriteLine(length2);
            if(length1 ==length2)
            {
                Console.WriteLine("two length of lines are equal");
            }
            else if(length1>=length2)
            {
                Console.WriteLine("length of line1 is greater than length of line2");
            }
            else
            {
                Console.WriteLine("length of line1 is less than length of line2");
            }

        }
    }
}
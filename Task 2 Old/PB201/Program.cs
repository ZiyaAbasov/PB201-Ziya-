using System.Numerics;

namespace PB201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            if (num == 0 || num == 1) 
            {
                Console.WriteLine("Neither prime  nor composite");
            }
            for (int i = 2; i <num ; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Num is Complex");
                    break;
                }
                else 
                {
                    Console.WriteLine("Num is prime");
                    break;
                }


            }
        }
    }
}

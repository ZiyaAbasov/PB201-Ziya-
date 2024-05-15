namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1000000;
            int count = 0;
            while (num >= 1 )
            {
                count++;
                num /= 10;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Number of steps: {count}");

        }
    }
}

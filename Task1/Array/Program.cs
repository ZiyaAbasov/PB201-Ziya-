namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int [10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 };
            int HighestNumber = num[0];
            for (int i = 1; i < num.Length; i++) 
            {
                if (num[i] > HighestNumber)
                    HighestNumber = num[i];

                    Console.WriteLine(num[i]);
            }

            //Console.WriteLine(num.Max);Bu isleyir lakin kecilmiyib 
           
        }
    }
}

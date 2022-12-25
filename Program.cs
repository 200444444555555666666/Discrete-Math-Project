using System;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter last number");
            int lastnumber = int.Parse(Console.ReadLine());

            for (int n=firstnumber ;n<=lastnumber;n++)
            {
                int sum = 0;
                for (int j = 1; j <= (n / 2); j++)
                { 
                   
                if (n % j == 0)
                    {
                        sum = sum + j;
                    }
                
                }
                if (sum == n)
                    Console.WriteLine(n);
                   
                
            }
        }
    }
}

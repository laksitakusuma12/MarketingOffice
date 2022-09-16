using System;

namespace OfficeProject
{
    class Program
    {
        int MarketingDailyReport()
        {
            int sum = 0;
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write($"Welcome {name}! \nPlease Input Amount of Marketing Daily Report Over Weekend \n\n");
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Enter Finished Marketing Daily Report On Day {i} : ");
                int amountProduct = Convert.ToInt32(Console.ReadLine());
                if (amountProduct <= 50)
                {    
                    sum += amountProduct;
                }
            }
            Console.Write("\nTotal of Finished Marketing Daily Report Over Weekend : " + sum + "\n");
            return sum;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.MarketingDailyReport();
        }
    }
}

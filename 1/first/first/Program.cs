using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int numbers;
            Console.WriteLine("welcome which food do you like to eat? ");
            Console.WriteLine("meat = $10");
            Console.WriteLine("rice = $12");
            Console.WriteLine("fish = $15");
            string input=Console.ReadLine();
            Console.WriteLine("how many  " + input + " do you want?");
             numbers =Convert.ToInt32( Console.ReadLine());

            if (input == "meat")
            {
                int tax = 10 * numbers * 8 / 100;
                Console.WriteLine(tax);
                Console.WriteLine("total = " + tax + 10 * numbers);
            }

            if (input == "fish")
            {
                int tax = 15 * numbers * 8 / 100;
                Console.WriteLine(tax);
                Console.WriteLine("total = " + tax + 15 * numbers);
            }

            if (input == "rice")
            {
                int tax = 12 * numbers * 8 / 100;
                Console.WriteLine(tax);
                Console.WriteLine("total = " + tax + 12 * numbers);
            }






        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int income;

            //this is never used
            int tax;


            //it`s about tax
            Console.WriteLine("your monthly income?");
            income = Convert.ToInt32(Console.ReadLine());
            if (income <= 100)
            {
                //what is a? bad naming 
                int a = income * 9 / 100;
                int total;
                total = income - a;

                Console.WriteLine("your tax is  " + a);


                Console.WriteLine("and your total is " + total);
                Console.WriteLine("enjoy");


            }

        }

    }
}

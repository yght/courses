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
            int age;
            Console.WriteLine("how much do you have?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 10)
            {
                Console.WriteLine("you are  kid");
            }
            else
            {
                Console.WriteLine("ok we;com to my programm");

            }
        }

    }
}

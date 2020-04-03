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
            // ENGLISH: HOW OLD ARE YOU?
            Console.WriteLine("how much do you have?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 10)
            {
                // >10 you are KID!??!?!? if (age <10) you are kid
                Console.WriteLine("you are  kid");
            }
            else
            {
                //Welocome to my program
                Console.WriteLine("ok we;com to my programm");

            }
        }

    }
}

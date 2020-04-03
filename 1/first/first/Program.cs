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
            Console.WriteLine("how much do you have?");
            string input = Console.ReadLine();
           if (input.Length<=1)
            {
                Console.WriteLine("you are so kid");
            }
        }

    }
}

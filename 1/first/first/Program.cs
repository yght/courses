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
            int number2;
            int number1;
            Console.WriteLine("ok. i want to sup up two number for you.first write enter number");
             number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and number2 ?");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("total =" + number1 + number2);
        }

    }
}

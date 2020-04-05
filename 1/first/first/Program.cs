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
           
            int number1;
            int number2;
            int apply;
            Console.WriteLine("it is a Calculator");
            Console.WriteLine("enter a number");
            number1=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("secound number?");
           number2= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("if you enter 1: sup up , if enter2: Subtraction ,if enter3: split , if enter4: beat");

           apply = Convert.ToInt32( Console.ReadLine());
            
            if (apply == 1)
            {
               Console.WriteLine( number1 + number2);
            }
            if (apply == 2)
            {
                Console.WriteLine(number1 - number2);
            }
            if (apply == 3)
            {
                Console.WriteLine(number1 / number2);
            }
            if (apply == 4)
            {
                Console.WriteLine(number1 * number2);
            }
            else
            {
                Console.WriteLine("you have to enter 1 until 4");
            }




        }

    }
}

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
            while (true)
            {
                int number1;
                int number2;

                
                Console.WriteLine("enter a number");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("secound number?");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ok. which operation do you want to do?");
                string input = (Console.ReadLine());
                
                        
                    
                        if (input == "+")
                        {
                            Console.WriteLine(number1 + number2);
                        }
                       else if (input == "-")
                        {
                            Console.WriteLine(number1 - number2);
                        }
                      else  if (input == "/")
                        {
                            Console.WriteLine(number1 / number2);
                        }

                      else  if (input == "*")
                        {
                            Console.WriteLine(number1 * number2);
                        }
                   else
                {
                    Console.WriteLine("you have to enter (+ - / *)");
                }

                   
                
            }
        }


    }

}

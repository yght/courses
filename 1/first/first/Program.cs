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
            
           
                 char yes;
                char no;


             Console.WriteLine("acciunting");
             Console.WriteLine("how much is your balance? ");
             int balance = Convert.ToInt32(Console.ReadLine());
             if (balance.GetType() == typeof(int))
             {
                Console.WriteLine("The information was successfully recorded");

             }
             else
             {
                 Console.WriteLine("you have to enter number");
             }
             Console.WriteLine("Did you have any operation today?    1= yes   2 = no ");
             string ask = Console.ReadLine();
             if (ask == "1")
            {
                Console.WriteLine("enter your number ");
                int number = Convert.ToInt32(Console.ReadLine());
               

                Console.WriteLine("what is your operation?  + - ");
                string operation = Convert.ToString(Console.ReadLine());
                 if (operation=="+")
                {
                    Console.WriteLine("New Inventory =" + balance + number);
                }
                 if(operation=="-")
                {
                    Console.WriteLine("New Inventory = " + (balance - number));

                }
              
            }
          
           

        }



    }


      
    }






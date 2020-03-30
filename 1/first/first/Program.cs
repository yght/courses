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
            while(true)
           {
            Console.WriteLine("what is your name? ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("you have to write your name");
                    return ;
             }
                

                Console.WriteLine("hello :" + name);
            }
        }


    
    }
}

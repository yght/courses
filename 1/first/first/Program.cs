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
            while (true)
            {
                Console.WriteLine("what is your name? ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("you have to write your name");

                    //HERE, it will finish the function, instead of return you have to go back to the begining of the loop
                    return;

                    // This makes your loop run until you enter a name.
                    // continue;
                }
                Console.WriteLine("hello :" + name);

                //        //this makes your loop finish, because you are here and it means you entered a name, then it will finish the loop
                //        break;
            }
        }

    }
}

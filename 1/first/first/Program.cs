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
            var ten = new List<int> { 0, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            int count = 0;
            foreach (int element in ten)
            {
                count++;
                Console.WriteLine($"number #{count}: {element}");
            }
            Console.WriteLine($"Number of numbers: {count}");

        }



    }


      
}






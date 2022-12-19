using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1_Project1_loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gess value.");
            Console.WriteLine("For exit enter - stop");

            const int Attempt = 5; // amount of attempt
            int counter = 0; // counter of attempt
            string fruit = "grape"; // what you should guess

            while (counter < Attempt)
            {
                counter++;
                Console.WriteLine("Attempt {0}", counter);
                string value = Console.ReadLine();
                    if (value == "stop")
                    {
                    break;
                    }
                    if (value != fruit)
                    {
                    continue;    
                    }
                Console.WriteLine("You guess from {0} attempt", counter);
                break;
            }
            Console.ReadKey();
        }
    }
}

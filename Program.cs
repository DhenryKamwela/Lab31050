using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrAns;
            bool isTrue;
            Console.WriteLine("True or False, the capital of Nigeria is Lagos?");
            usrAns = Console.ReadLine();

            if (usrAns == "True" || usrAns=="true")
            {
                isTrue = true;
            }
            else
            {
               isTrue = false;
            }


            if (isTrue)
            {
                Console.WriteLine("It is true.");
            }
            else
            {
                Console.WriteLine("It is false.");
            }

            Console.ReadKey();
















        }
    }
}

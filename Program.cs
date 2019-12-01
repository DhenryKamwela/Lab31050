using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35;
            int b = 42;
            
            int userANS;
           
            Console.WriteLine(" Enter your speed ");
            userANS = Convert.ToInt32(Console.ReadLine());
            if (userANS > b)
            {
                Console.WriteLine(" SLOW DOWN NOW! ");

            }
            else if (userANS > a)
            {
                Console.WriteLine(" Goodjob driving the speed limit ");
            }
            else
            {
                Console.WriteLine("You need to speed up!");
            }
                
            Console.ReadKey();

              
















        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.) The if single-selection statement selects or ignores a single action, while the while repetition statement is dynamic and can change based on weather or not something is true or false.

            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
            { Console.WriteLine("SLOW NOW");
                Console.ReadLine();
            }
            //--------------------------------------------------------------
            bool isTrue = true;

            if (isTrue)

            { Console.WriteLine("It is True!"); }

            else
            { Console.WriteLine("It is False!"); }
            Console.ReadLine();
            //--------------------------------------------------------------

            Console.WriteLine("Enter Temperature: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius:{0}", celsius);
            Console.ReadLine();

            if (fahrenheit >=90)
             Console.WriteLine("It is Hot!");
            



            if (fahrenheit <=40)
             Console.WriteLine("It is Cold!");
            Console.ReadLine();
            //---------------------------------------------------------------

            int a = 1;

            while (a<11)
            { Console.Write("Value:");
                Console.WriteLine(a); a++;
                Console.ReadLine();
            }
            //---------------------------------------------------------------
            int b = 60;
            while (b>20)
            { Console.Write("Value:");
                Console.WriteLine(b);
                b -= 5;
                Console.ReadLine();
            }
            //---------------------------------------------------------------

            int c = 10;

                while (c<20)
            { Console.Write("Value:");
                Console.WriteLine(c);
                c += 2;
                Console.ReadLine();
            }

            

        }
    }
}

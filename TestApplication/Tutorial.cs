using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Tutorial
    {
        // Static keyword
        public static void run()
        {
            // start our tutorial 
            // nullable type
            // string, int, double, decimal

            // nullable
            int? number = null;
            double? number2 = null;
            decimal? number3 = null;
            string text = null;
            bool? test = null;

            // true or false
            bool isDianaAwesome = false;
            bool isDianaCool = false;


            if (isDianaAwesome && isDianaCool)
            {
                Console.WriteLine("Diana is awesome");
            }
            else
            {
                Console.WriteLine("Diana is a butt hole");
            }

            Console.WriteLine(isDianaAwesome && isDianaCool);
            Console.WriteLine(isDianaAwesome || isDianaCool);


            int num1 = 10;
            int num2 = 5;

            if(num1 / num2 == 2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }

        public void run2()
        {
            Console.WriteLine("Diana is awesome");
        }
    }
}

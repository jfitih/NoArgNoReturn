using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply.cs
{
    class Multiply
    {
        // A number is to be Multiplied By 4
        // In my attempt to see how the Number any particular (number)
        public static int MultiplyBy4(int aNumber) { return 4 * aNumber;
        }
        static void Main(string[] args)
        {
            //This makes no sense ???????
            int x = 7; //This is suppose to start (x) at 7
            int y = 20;//This is suppose to initulize y at 20
            int z = -3;//This is suppose to initulize z -3
            int result = 0;// This is the result place holder
            result = MultiplyBy4 (x);
            Console.WriteLine("Stop plying with me.\n What does this mean\nPassing a variable, x: {0} \n What!!!!!!!!", result);
            result = MultiplyBy4 (y + 2);
            Console.WriteLine("\ny+2\nThis makes nosense to no damn body\n\tWhy the hell is someone even interested in Passing an expression, y+2: {0}\n what", result);
            result = 5 + MultiplyBy4(z);
            Console.WriteLine("Using MultiplyBy4 in an expression: {0}\n what", result);
            result = MultiplyBy4(31);
            Console.WriteLine("Passing a constant, 31: {0}\n what", result);
            Console.WriteLine("Passing an expression to WriteLine; {0}\n what", MultiplyBy4 (y));
            Console.ReadLine();
        }//Work on later
    }
}

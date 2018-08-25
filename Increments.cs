using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment.cs
{
    class Increment
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int a = 3;
            int b = 3;
            int j = 7;
            int k = 7;
            int result = 0;
            j++;
            ++k;
            Console.WriteLine("j = {0} and k = {1}", j,k);
            j--;
            --k;
            Console.WriteLine("j = {0} and k = {1}", j, k);
            result = 3 + x++;
            Console.WriteLine("My result is = {0} and x is 3 + x++ is = {1}", result, x);
            result = 3 + ++y;
            Console.WriteLine("My result is = {0} and y = {1}", result, y);
            result = 2 + a--;
            Console.WriteLine("My result is = {0} and a = {1}", result, a);
            result = 2 + --b;
            Console.WriteLine("My result is = {0} and b = {1}", result, b);
            Console.ReadLine();
        }
    }
}

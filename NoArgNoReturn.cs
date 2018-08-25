using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoArgsNoReturn.cs
{
    class NoArgsNoReturn
    {
        //Displays a message
        public static void PrintBlurb()
        {
            Console.WriteLine("This method has no arugments, "
                + "and it has no return value.");
            Console.Write("What the fucc does this mean \n" +
                " Is it trying to tell me that the method is\n" +
                " Grabbing the Print blurb method to write this out to say this.\n" +
                "????????????????????????? ");
        }
        //Execution starts here
        static void Main(string[] args)
        {
            PrintBlurb();
            Console.ReadLine();
        }
    }
}

using System;
//Names our program
namespace project0
{
    //Defines the main class
    class Program
    {
        //calls forth the main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            //make some bytes
            byte a,b;
            //give them a value
            a = 1;
            b = 2;
            //do some math
            Console.WriteLine("{0}",a," + {0}",b," = {0}",a+b);
        }
    }
}

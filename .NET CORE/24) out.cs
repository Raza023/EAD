using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        //ref variable must be initialized before caller function and callee gets the same value(refernce) and we can change it. (two way)(callee <-> caller)
        //out variable can be unassigned before caller function and must have to be initialized in callee function.    (one way)(callee -> caller)
        public static double squareRoot(double a,out double b)
        {
            double x=a;
            a=Math.Sqrt(x);
            b=Math.Sqrt(x)*-1;
            return a;
        }
        static void Main(string[] args)
        {
            double a=4;
            double b=2;
            Console.WriteLine(squareRoot(a,out b));
            Console.WriteLine(b);
        }
    }
}
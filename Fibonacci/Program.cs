using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciDifferentDataTypes
    {
        public void FibonacciInteger()
        {
            int[] F = new int[101];

            F[0] = 0;
            F[1] = 1;

            for (int n = 2; n <= 100; n++)
            {
                F[n] = F[n - 1] + F[n - 2];
            }
            Console.Write("The Fibonacci Series from 0 to 100 is = ");


            for (int x = 0; x <= 100; x++)
            {
                string delimiter = (x == 100)?"." :",";
                Console.Write(F[x] + delimiter);
            }
        }
        public void FibonacciLong()
        {
            long[] F = new long[101];

            F[0] = 0;
            F[1] = 1;

            for (int n = 2; n <= 100; n++)
            {
                F[n] = F[n - 1] + F[n - 2];
            }
            Console.Write("The Fibonacci Series from 0 to 100 is = ");


            for (int x = 0; x <= 100; x++)
            {
                string delimiter = (x == 100) ? "." : ",";
                Console.Write(F[x] + delimiter);
            }
        }
        public void FibonacciDouble()
        {
            Double[] F = new Double[101];

            F[0] = 0;
            F[1] = 1;

            for (int n = 2; n <= 100; n++)
            {
                F[n] = F[n - 1] + F[n - 2];
            }
            Console.Write("The Fibonacci Series from 0 to 100 is = ");


            for (int x = 0; x <= 100; x++)
            {
                string delimiter = (x == 100) ? "." : ",";
                Console.Write(F[x] + delimiter);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //The program generates Fibonacci numbers between 0 to 100;
            FibonacciDifferentDataTypes fddt = new FibonacciDifferentDataTypes();

            Console.WriteLine(" ");
            Console.WriteLine("Generating using Integer");
            Console.WriteLine("----");
            fddt.FibonacciInteger();
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("Generating using Long");
            Console.WriteLine("----");
            fddt.FibonacciLong();
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("Generating using Double");
            Console.WriteLine("----");
            fddt.FibonacciDouble();
            Console.WriteLine(" ");

            //Integer and Long or Big Integer will not handle the series properly. the number will wrap around and start with the minimum value, -2^31, or -2,147,483,648.
            //So you will always have negative values...
            //So for a Fibonacci Series use Double Datatype.
        }
    }
}

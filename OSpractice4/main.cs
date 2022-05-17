using System;
using System.Diagnostics;
using System.Threading;
namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int b = 2;
            int c = 3;

            DateTime start = DateTime.Now;
            
            for (int i = 0; i <= 1000000001; i++) {
                a += b * 2 + c - i;
            }

            Console.WriteLine(DateTime.Now - start);
        }
    }
}
using System;
using System.Threading;

namespace ConsoleApp1.Session8
{
    public class Session8
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start(); // chay luong moi 
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = "+i);
                Thread.Sleep(100);
            }
        }

        public static void ThreadRun()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = "+i);
                Thread.Sleep(100);
            }
        }
    }
}
using System;
using System.Threading;

namespace ConsoleApp1.Session8
{
    public class Lab8
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start();
        }

        public static void ThreadRun()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    // keyword: number format 01 02 in C#
                    Console.WriteLine(i.ToString("D2")+":"+j.ToString("D2"));
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("Boom...");
        }
    }
}
using System;

namespace ConsoleApp1.Session3
{
    public class Woman:Human
    {
        public override void AddFriend()
        {
            
        }
        public override void Running()
        {
            Console.WriteLine("Vua chay vua hat..");
        }

        public new void Eat()
        {
            Console.WriteLine("Eating and Sing...");
        }
    }
}
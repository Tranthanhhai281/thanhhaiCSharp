
using System;

namespace ConsoleApp1.GeometryExample
{
    public class Cylinder
    {
        private double BaseArea;
        private double LareralArca;
        private double TotalArea;
        private double Volume;
        
        public void Process(double Radius, double Height)
        {
            BaseArea =  Radius * Radius * Math.PI;
            LareralArca = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Base: "+this.BaseArea+ "\nLateral: "+this.LareralArca+
                              "\nTotal: "+this.TotalArea+
                              "\nVolume: "+this.Volume);
        }

        
    }
}
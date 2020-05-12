﻿using System;

namespace ConsoleApp1.GeometryExample
{
    public class Base
    {
        protected string name;
        protected int weight;

        public Base(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine("Name:" + Name + ",\t"  +"Weight:" + Weight );
        }

        public virtual void SetMe(string name, int weight)
        {
            
        }
    }
}
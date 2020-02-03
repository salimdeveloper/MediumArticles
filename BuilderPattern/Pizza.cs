using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Pizza
    {
        public BaseType BaseType { get; set; }
        public bool IsHandTosted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine($"Your Pizza:");
            Console.WriteLine($"Has base :{this.BaseType.ToString()}\n");
            Console.WriteLine($"-Hand Toasted:{this.IsHandTosted.ToString()}\n");
            Console.WriteLine($"-With Cheese:{this.CheeseType.ToString()} \n");
            if (this.MeatType != MeatType.None)
            {
                Console.WriteLine($"-With Meat:{this.MeatType.ToString()}\n");
            }
            if (Vegetables != null)
            {
                Console.WriteLine($"With Vegetables:\n");
                foreach (var vege in Vegetables)
                {
                    Console.WriteLine($"--{vege.ToString()}\n");
                }
            }

        }


    }

}

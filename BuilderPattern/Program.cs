using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
      


            var _PizzaMaker = new PizzaMaker(new Margherita());
            var _mp = _PizzaMaker.Construct();
            _mp.Display();

            _PizzaMaker = new PizzaMaker(new ClassicChicken());
            var _cp = _PizzaMaker.Construct();
            _cp.Display();
            

            var _margherita = new Pizza();
            _margherita.BaseType = BaseType.ThinCrust;
            _margherita.IsHandTosted = true;
            _margherita.CheeseType = CheeseType.Cheddar;
            _margherita.MeatType = MeatType.None;// No Meat in Margherita.
            _margherita.Vegetables = null;//No Vegetables in Margherita.
            _margherita.Display();

            Console.ReadLine();
        }
    }
}

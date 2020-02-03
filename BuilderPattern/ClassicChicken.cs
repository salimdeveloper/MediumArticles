using System.Collections.Generic;

namespace BuilderPattern
{
    public class ClassicChicken : PizzaBuilder
    {
        private Pizza _pizza;
        public ClassicChicken()
        {
            _pizza = new Pizza();
        }
        public override Pizza GetResult()
        {
            SetBase();
            IsPizzaHandTosted();
            AddCheese();
            AddMeats();
            AddVeges();
            return _pizza;
        }

        internal override void AddCheese()
        {
            _pizza.CheeseType = CheeseType.Cheddar;
        }

        internal override void AddMeats()
        {
            _pizza.MeatType = MeatType.Chicken;
        }

        internal override void AddVeges()
        {
            List<string> veges = new List<string>();
            veges.Add("onion");
            _pizza.Vegetables = veges;
        }

        internal override void IsPizzaHandTosted()
        {
            _pizza.IsHandTosted = true;
        }

        internal override void SetBase()
        {
            _pizza.BaseType = BaseType.ThickCrust;
        }
    }
}

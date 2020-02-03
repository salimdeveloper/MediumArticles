namespace BuilderPattern
{
    public class Margherita : PizzaBuilder
    {
        private Pizza _pizza;
        public Margherita()
        {
            _pizza = new Pizza();
        }
        internal override void AddCheese()
        {
            _pizza.BaseType = BaseType.ThinCrust;

        }
        internal override void AddMeats()
        {

            _pizza.MeatType = MeatType.None;
        }
        internal override void AddVeges()
        {

        }
        public override Pizza GetResult()
        {
            SetBase();
            IsPizzaHandTosted();
            AddCheese();
            return _pizza;
        }
        internal override void IsPizzaHandTosted()
        {
            _pizza.IsHandTosted = true;
        }
        internal override void SetBase()
        {
            _pizza.BaseType = BaseType.ThinCrust;

        }
    }

}

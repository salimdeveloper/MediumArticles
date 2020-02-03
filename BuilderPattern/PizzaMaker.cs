namespace BuilderPattern
{
    public class PizzaMaker
    {
        private PizzaBuilder _concreteBuilder;

        public PizzaMaker(PizzaBuilder concreteBuilder)
        {
            _concreteBuilder = concreteBuilder;
        }

        public Pizza Construct()
        {
            return _concreteBuilder.GetResult();
        }
    }

}

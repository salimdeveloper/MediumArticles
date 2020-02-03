namespace BuilderPattern
{
    public abstract class PizzaBuilder
    {
        public abstract Pizza GetResult();
        internal abstract void SetBase();
        internal abstract void IsPizzaHandTosted();
        internal abstract void AddCheese();
        internal abstract void AddMeats();
        internal abstract void AddVeges();
    }

}

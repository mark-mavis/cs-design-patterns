namespace AbstractContinentFactory
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    public abstract class Herbivore
    {
        public abstract void Eat();
    }
}

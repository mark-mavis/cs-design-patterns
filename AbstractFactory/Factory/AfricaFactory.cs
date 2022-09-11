namespace AbstractContinentFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wilderbeast();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}


namespace AbstractContinentFactory
{
    class Bison : Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine(this.GetType().Name + " eats grass");
        }
    }
}

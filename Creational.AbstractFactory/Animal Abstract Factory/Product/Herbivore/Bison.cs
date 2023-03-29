
namespace Creational.AbstractFactory.Animal;

class Bison : Herbivore
{
    public override void Eat()
    {
        Console.WriteLine(this.GetType().Name + " eats grass");
    }
}

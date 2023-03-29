
namespace Creational.AbstractFactory.Animal;

class Lion : Carnivore
{
    public override void Eat(Herbivore h)
    {
        Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
    }
}

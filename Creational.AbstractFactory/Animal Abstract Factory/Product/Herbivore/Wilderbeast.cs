namespace Creational.AbstractFactory.Animal;

class Wilderbeast : Herbivore
{
    public override void Eat()
    {
        Console.WriteLine(this.GetType().Name + " eats grass");
    }
}

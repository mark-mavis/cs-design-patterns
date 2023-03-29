namespace Creational.AbstractFactory.GenericFactory;

class ProductA1 : AbstractProductA
{
    public override void Interact(AbstractProductB a)
    {
        Console.WriteLine(GetType().Name +
            " interacts with " + a.GetType().Name);
    }
}

namespace Creational.AbstractFactory.GenericFactory;

class ProductA2 : AbstractProductA
{
    public override void Interact(AbstractProductB a)
    {
        Console.WriteLine(GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}

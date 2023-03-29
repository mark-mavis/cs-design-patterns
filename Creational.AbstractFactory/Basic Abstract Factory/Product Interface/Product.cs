namespace Creational.AbstractFactory.GenericFactory;

abstract class AbstractProductA
{
    public abstract void Interact(AbstractProductB a);
}

abstract class AbstractProductB
{
    public abstract void Interact(AbstractProductA a);
}

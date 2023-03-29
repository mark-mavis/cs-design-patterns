﻿namespace Creational.AbstractFactory.GenericFactory;

class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
    }
}

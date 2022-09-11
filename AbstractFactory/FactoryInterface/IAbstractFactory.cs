namespace AbstractProductFactory
{
    abstract class IAbstractFactory
    {
        //Public Abstract Function. Creat
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}


namespace AbstractProductFactory
{
    class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }
    
}

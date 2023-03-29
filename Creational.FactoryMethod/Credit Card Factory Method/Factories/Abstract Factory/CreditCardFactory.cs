namespace Creational.AbstractFactory.CreditCardFactory;

abstract class CreditCardFactory
{
    protected abstract ICreditCardTerms MakeProduct();
    public ICreditCardTerms GetProduct()
    {
        return this.MakeProduct();
    }
}


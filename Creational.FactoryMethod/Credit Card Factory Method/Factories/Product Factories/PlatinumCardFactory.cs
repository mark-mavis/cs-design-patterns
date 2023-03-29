namespace Creational.AbstractFactory.CreditCardFactory;

class PlatinumCardFactory : CreditCardFactory
{
    protected override ICreditCardTerms MakeProduct()
    {
        return new PlatinumCard();
    }
}


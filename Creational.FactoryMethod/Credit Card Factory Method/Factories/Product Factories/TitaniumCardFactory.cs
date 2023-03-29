namespace Creational.AbstractFactory.CreditCardFactory;
class TitaniumCardFactory : CreditCardFactory
{
    protected override ICreditCardTerms MakeProduct()
    {
        return new TitaniumCard();
    }
}


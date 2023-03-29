namespace Creational.AbstractFactory.CreditCardFactory;

class MoneyBackCardFactory : CreditCardFactory
{
    protected override ICreditCardTerms MakeProduct()
    {
        return new MoneyBackCard();
    }
}


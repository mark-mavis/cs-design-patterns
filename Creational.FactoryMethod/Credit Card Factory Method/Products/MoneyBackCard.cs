namespace Creational.AbstractFactory.CreditCardFactory;
class MoneyBackCard : ICreditCardTerms
{
    public int GetAnnualCost()
    {
        return 100;
    }

    public int GetLimit()
    {
        return 7000;
    }

    public string GetCardType()
    {
        return "Money Back Card";
    }
}


namespace Creational.AbstractFactory.CreditCardFactory;
class PlatinumCard : ICreditCardTerms
{
    public int GetAnnualCost()
    {
        return 500;
    }

    public int GetLimit()
    {
        return 25000;
    }

    public string GetCardType()
    {
        return "Platinum Card";
    }
}


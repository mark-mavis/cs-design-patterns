namespace Creational.AbstractFactory.CreditCardFactory;
interface ICreditCardTerms
{
    string GetCardType();
    int GetAnnualCost();
    int GetLimit();
}


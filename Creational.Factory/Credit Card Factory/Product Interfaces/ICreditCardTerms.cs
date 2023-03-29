namespace Creational.Factory
{
    interface ICreditCardTerms
    {
        string GetCardType();
        int GetLimit();
        int GetAnnualCost();
    }
}

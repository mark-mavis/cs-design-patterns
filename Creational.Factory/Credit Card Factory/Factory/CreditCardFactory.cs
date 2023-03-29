namespace Creational.Factory
{
    class CreditCardFactory
    {
        public static ICreditCardTerms GetCardByType(string card_type)
        {
            ICreditCardTerms creditCard = null;
            if (card_type == "Platinum")
            {
                creditCard = new Platinum();
            }
            else if (card_type == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (card_type == "Money Back")
            {
                creditCard = new MoneyBack();
            }
            return creditCard;
        }
    }
}

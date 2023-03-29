namespace Creational.Factory
{
    class Program
    {
        static void Main() {
            ICreditCardTerms credit_card = CreditCardFactory.GetCardByType("Platinum");
            Console.WriteLine($"Card Type: {credit_card.GetType()}");
            Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
            Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");

            Console.WriteLine("-----------------------------");

            credit_card = CreditCardFactory.GetCardByType("Titanium");
            Console.WriteLine($"Card Type: {credit_card.GetType()}");
            Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
            Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");

            Console.WriteLine("-----------------------------");

            credit_card = CreditCardFactory.GetCardByType("Money Back");
            Console.WriteLine($"Card Type: {credit_card.GetType()}");
            Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
            Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");
        }
    }
}




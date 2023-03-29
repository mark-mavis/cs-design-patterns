using Creational.AbstractFactory.CreditCardFactory;
using Creational.AbstractFactory.MobileFactory;
class Program
{
    static void Main()
    {
        ICreditCardTerms credit_card = new PlatinumCardFactory().GetProduct();
        Console.WriteLine($"Card Type: {credit_card.GetCardType()}");
        Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
        Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");

        Console.WriteLine("-----------------------------");

        credit_card = new TitaniumCardFactory().GetProduct();
        Console.WriteLine($"Card Type: {credit_card.GetCardType()}");
        Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
        Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");

        Console.WriteLine("-----------------------------");

        credit_card = new MoneyBackCardFactory().GetProduct();
        Console.WriteLine($"Card Type: {credit_card.GetCardType()}");
        Console.WriteLine($"Card Limit: {credit_card.GetLimit()}");
        Console.WriteLine($"Annual Cost: {credit_card.GetAnnualCost()}");

        //Using the Concrete Samsung Factory to create that factor
        IMobile galaxy = new SamsungFactory().GetProduct(ModelType.Galaxy);
        galaxy.PrintDetails();
        
        IMobile a9 = new SamsungFactory().GetProduct(ModelType.A9);
        a9.PrintDetails();
        
        IMobile redmi6 = new XiaomiFactory().GetProduct(ModelType.Redmi6);
        redmi6.PrintDetails();
        
        IMobile redmipro = new XiaomiFactory().GetProduct(ModelType.RedmiPro);
        redmipro.PrintDetails();

    }
}
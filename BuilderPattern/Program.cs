using BuilderPattern.Builder;
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;


public class Program
{
    public static void Main(string[] args)
    {
        IAccountBuilder accountBuilder = new LoanAccountBuilder();
        AccountConfigurationBuilder configBuilder = new AccountConfigurationBuilder();

        var loanAccount = configBuilder.BuildLoanAccount(accountBuilder);

        Console.WriteLine($"The loan account detail - Account Number: {loanAccount.AccountNumber}" + $" Loan Amount: {loanAccount.LoanAmount}");
        Console.ReadKey();
    }
}
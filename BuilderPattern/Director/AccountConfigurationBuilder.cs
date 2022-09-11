using BuilderPattern.Product;
using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAccount(IAccountBuilder builder)
        {
            //the builder is a copy of the Builder Interface
            builder.AddAccountNumber(123456);
            builder.AddCredential("markwmavis", "6275");
            builder.WithLoanAmount(10000);
            builder.AddInterestRate(10.5);

            return builder.GetAccount();
        }

        public Account BuildSavingsAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(654321);
            builder.WithSavingsBalance();

            return builder.GetAccount();
        }
    }
}

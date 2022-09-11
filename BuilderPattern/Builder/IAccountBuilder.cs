using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IAccountBuilder
    {
        void AddAccountNumber(long accountNumber);
        void AddCredential(string userName, string password);
        void WithLoanAmount(double loanAmount);
        void AddInterestRate(double interestRate);
        void WithSavingsBalance();
        Account GetAccount();
    }
}

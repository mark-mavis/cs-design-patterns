using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class SavingsAccountBuilder : IAccountBuilder
    {
        private Account _savingsAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _savingsAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _savingsAccount.UserName = userName;
            _savingsAccount.Password = password;
        }

        public void AddInterestRate(double interestRate)
        {
            _savingsAccount.LoanAmount = interestRate;
        }

        public void WithLoanAmount(double loanAmount)
        {
            _savingsAccount.InterestRate = loanAmount;
        }

        public void WithSavingsBalance()
        {
            _savingsAccount.Balance = 10000;
        }

        public Account GetAccount()
        {
            return _savingsAccount;
        }
    }
}

using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class LoanAccountBuilder : IAccountBuilder
    {
        private Account _loanAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredential(string userName, string password)
        {
            _loanAccount.UserName = userName;
            _loanAccount.Password = password;
        }

        public void AddInterestRate(double interestRate)
        {
            _loanAccount.LoanAmount = interestRate;
        }

        public void WithLoanAmount(double loanAmount)
        {
            _loanAccount.InterestRate = loanAmount;
        }

        public void WithSavingsBalance()
        {
            _loanAccount.Balance = 10000;
        }

        public Account GetAccount()
        {
            return _loanAccount;
        }
    }
}

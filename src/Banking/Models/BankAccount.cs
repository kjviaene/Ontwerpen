namespace Banking.Models
{
    public class BankAccount
    {
        public const decimal WithdrawCost = 0.25M; //M zorgt ervor dat die decimal behoud en geen double probeert

        #region Constructors
        public BankAccount(string accountNumber) : this(accountNumber, 0)
        {

        }
        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        #endregion

        #region Methodes

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        } 
        #endregion



        #region Properties
        public decimal Balance { get; private set; }

        public string AccountNumber { get; set; } 
        #endregion
    }
}

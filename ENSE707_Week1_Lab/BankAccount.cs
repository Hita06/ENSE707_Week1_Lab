namespace ENSE707_Week1_Lab;

public class BankAccount
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal openingBalance)
    {
        if (openingBalance < 0)
        {
            throw new ArgumentException("Opening balance cannot be negative.");
        }

        AccountHolder = accountHolder;
        Balance = openingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }

    public decimal CalculateTransactionFee(decimal amount)
    {
        return amount * 0.02m;
    }
}
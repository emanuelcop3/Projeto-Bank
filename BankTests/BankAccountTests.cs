// Constructor to initialize an instance of BankAccount.
public BankAccount(string customerName, double balance)
{
    m_customerName = customerName;
    m_balance = balance;
}

// Read-only properties to access account information.
public string CustomerName => m_customerName;
public double Balance => m_balance;

// Method to debit an amount from the account.
public void Debit(double amount)
{
    // Checks if the debit amount is greater than the available balance.
    if (amount > m_balance)
    {
        throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountExceedsBalanceMessage);
    }

    // Checks if the debit amount is less than zero.
    if (amount < 0)
    {
        throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountLessThanZeroMessage);
    }

    // Subtracts the debit amount from the account balance.
    m_balance -= amount;
}

// Method to credit an amount to the account.
public void Credit(double amount)
{
    // Checks if the credit amount is less than zero.
    if (amount < 0)
    {
        throw new System.ArgumentOutOfRangeException(nameof(amount), amount, CreditAmountLessThanZeroMessage);
    }

    // Adds the credit amount to the account balance.
    m_balance += amount;
}

// Main method for example purposes.
public static void Main()
{
    // Example of using the BankAccount class.
    BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

    ba.Credit(5.77);
    ba.Debit(11.22);
    Console.WriteLine($"Current balance: ${ba.Balance}");
}

// Constants for error messages.
public const string DebitAmountExceedsBalanceMessage = "The debit amount exceeds the available balance.";
public const string DebitAmountLessThanZeroMessage = "The debit amount must be greater than or equal to zero.";
public const string CreditAmountLessThanZeroMessage = "The credit amount must be greater than or equal to zero.";

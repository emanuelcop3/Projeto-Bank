// Classe BankAccount representa uma conta bancária simples.
public class BankAccount
{
    private readonly string m_customerName;
    private double m_balance;

    // Construtor para inicializar uma instância de BankAccount.
    public BankAccount(string customerName, double balance)
    {
        m_customerName = customerName;
        m_balance = balance;
    }

    // Propriedades somente leitura para acessar informações da conta.
    public string CustomerName => m_customerName;
    public double Balance => m_balance;

    // Método para debitar um valor da conta.
    public void Debit(double amount)
    {
        // Verifica se o valor do débito é maior que o saldo disponível.
        if (amount > m_balance)
        {
            throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountExceedsBalanceMessage);
        }

        // Verifica se o valor do débito é menor que zero.
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountLessThanZeroMessage);
        }

        // Subtrai o valor do débito do saldo da conta.
        m_balance -= amount;
    }

    // Método para creditar um valor na conta.
    public void Credit(double amount)
    {
        // Verifica se o valor do crédito é menor que zero.
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException(nameof(amount), amount, CreditAmountLessThanZeroMessage);
        }

        // Adiciona o valor do crédito ao saldo da conta.
        m_balance += amount;
    }

    // Método Main para fins de exemplo.
    public static void Main()
    {
        // Exemplo de uso da classe BankAccount.
        BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

        ba.Credit(5.77);
        ba.Debit(11.22);
        Console.WriteLine($"Saldo atual: ${ba.Balance}");
    }

    // Constantes para mensagens de erro.
    public const string DebitAmountExceedsBalanceMessage = "O valor do débito excede o saldo disponível.";
    public const string DebitAmountLessThanZeroMessage = "O valor do débito deve ser maior ou igual a zero.";
    public const string CreditAmountLessThanZeroMessage = "O valor do crédito deve ser maior ou igual a zero.";
}

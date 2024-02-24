using Microsoft.VisualStudio.TestTools.UnitTesting;

// Classe de testes para a classe BankAccount.
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        // Teste para verificar se um débito válido atualiza o saldo corretamente.
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "A conta não foi debitada corretamente");
        }

        // Outros métodos de teste podem ser adicionados aqui para diferentes cenários.

        // ...
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENSE707_Week1_Lab;

namespace ENSE707_Week1_Lab.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Alice", 100);

            // Act
            account.Deposit(50);

            // Assert
            Assert.AreEqual(150m, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ShouldDecreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Alice", 100);

            // Act
            account.Withdraw(30);

            // Assert
            Assert.AreEqual(70m, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ShouldNotAllowOverdraft()
        {
            // Arrange
            BankAccount account = new BankAccount("Alice", 100);

            // Act
            bool result = account.Withdraw(150);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void CalculateTransactionFee_ShouldReturnTwoPercent()
        {
            // Arrange
            BankAccount account = new BankAccount("Alice", 100);

            // Act
            decimal fee = account.CalculateTransactionFee(50);

            // Assert
            Assert.AreEqual(1m, fee);
        }
        [TestMethod]
public void Constructor_NegativeOpeningBalance_ThrowsException()
{
    Assert.ThrowsExactly<ArgumentException>(() =>
        new BankAccount("Test User", -100));
}
[TestMethod]
public void Deposit_NegativeAmount_ThrowsException()
{
    BankAccount account = new BankAccount("Test User", 100);

    Assert.ThrowsExactly<ArgumentException>(() =>
        account.Deposit(-20));

    Assert.AreEqual(100m, account.Balance);
}
[TestMethod]
public void Withdraw_NegativeAmount_ReturnsFalse()
{
    BankAccount account = new BankAccount("Test User", 100);

    bool result = account.Withdraw(-20);

    Assert.IsFalse(result);
    Assert.AreEqual(100m, account.Balance);
}
[TestMethod]
public void CalculateTransactionFee_ValidAmount_ReturnsTwoPercentFee()
{
    BankAccount account = new BankAccount("Test User", 100);

    decimal fee = account.CalculateTransactionFee(200);

    Assert.AreEqual(4.00m, fee);
}
    }
}


using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountTests
    {
        [Fact]
        public void NewAccountHaveCorrectBalance()
        {
            // Write the code you wish you had

            BankAccount account = new BankAccount();

            decimal balance = account.GetBalance();

            Assert.Equal(1200M, balance);
        }

        [Fact]
        public void DepositingIncreasesBalance()
        {
            // (Arrange)
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            // (Act)
            var amountToDeposit = 100M;
            account.Deposit(amountToDeposit);

            // (Assert)
            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }

        [Fact]
        public void WithdrawalsDecreaseBalance()
        {
            // (Arrange)
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            // (Act)
            var amountToWithdraw = 100M;
            account.Withdraw(amountToWithdraw);

            // (Assert)
            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }
    }
}

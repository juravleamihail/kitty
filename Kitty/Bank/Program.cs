using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bank
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void TransferFunds()
        {
            Account source = new Account();
            source.Deposit(200m);
            Assert.AreEqual(200m, source.Balance);

            Account destination = new Account();
            destination.Deposit(250m);

            Assert.AreEqual(250m, destination.Balance);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(350m, destination.Balance);
            
        }

        static void Main(string[] args)
        {

        }
    }

    
}

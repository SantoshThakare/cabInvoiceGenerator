using CabInvoiceGenerator1;
using NUnit.Framework;


namespace NUnitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_cost_ShouldMatches_ToActualCost()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double actual = invoiceGenerator.CalculateFare(3, 5);
            Assert.AreEqual(35, actual);
        }
        
        [Test]
        public void When_ActualCost_LessThanMinimumCost_ThrowException()
        {
            try
            {
                InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
                double actual = invoiceGenerator.CalculateFare(0.4, 0.2);
                Assert.AreEqual(5.0, actual);
            }
            catch (CabInvoiceGeneratorCustomException e)
            {
                Assert.AreEqual("Cost Could not LessThan Minimum Cost", e.Message);
            }
        }
    }
}
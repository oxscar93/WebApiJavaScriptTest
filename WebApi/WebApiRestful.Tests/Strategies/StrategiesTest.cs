using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiRestful.QuotationStrategies;
using System.Net;

namespace WebApiRestful.Tests.Strategies
{
    [TestClass]
    public class StrategiesTest
    {
        private QuotationStrategyFactory factory;

        [TestInitialize]
        public void Setup()
        {
            factory = new QuotationStrategyFactory();
        }

        [TestMethod]
        public void TestStrategyPesos()
        {
            var strategy = factory.GetQuotationStrategy("Pesos");

            Assert.IsTrue(strategy.GetType() == typeof(PesosQuotationStrategy));
        }

        [TestMethod]
        public void TestStrategyReal()
        {
            var strategy = factory.GetQuotationStrategy("Real");

            Assert.IsTrue(strategy.GetType() == typeof(RealQuotationStrategy));
        }

        [TestMethod]
        public void TestStrategyDolar()
        {
            var strategy = factory.GetQuotationStrategy("Dolar");

            Assert.IsTrue(strategy.GetType() == typeof(DolarQuotationStrategy));
        }

        [TestMethod]
        public void TestStrategyDolarGetValue()
        {
            var strategy = factory.GetQuotationStrategy("Dolar");

            var result = strategy.GetQuotation();

            Assert.IsTrue(result.Result == HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStrategyRealGetValue()
        {
            var strategy = factory.GetQuotationStrategy("Real");

            var result = strategy.GetQuotation();

            Assert.IsTrue(result.Result == HttpStatusCode.Unauthorized);
        }

        [TestMethod]
        public void TestStrategyPesosGetValue()
        {
            var strategy = factory.GetQuotationStrategy("Pesos");

            var result = strategy.GetQuotation();

            Assert.IsTrue(result.Result == HttpStatusCode.Unauthorized);
        }

    }
}

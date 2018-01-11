using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRestful.QuotationStrategies
{
    public class QuotationStrategyFactory
    {
        private IDictionary<string, AbstractQuotationStrategy> _strategies;
        public QuotationStrategyFactory()
        {
            _strategies = new Dictionary<string, AbstractQuotationStrategy>
                                                    {
                                                         {"Pesos", new PesosQuotationStrategy()},
                                                         {"Dolar", new DolarQuotationStrategy()},
                                                         {"Real", new RealQuotationStrategy()},
                                                     };       
        }

        public AbstractQuotationStrategy GetQuotationStrategy(string currency)
        {
            AbstractQuotationStrategy strategy = new DefaultQuotationStrategy();
            _strategies.TryGetValue(currency, out strategy);

            return strategy ?? new DefaultQuotationStrategy(); 
        }
    }
}
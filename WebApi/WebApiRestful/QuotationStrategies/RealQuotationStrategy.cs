using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.Services;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.QuotationStrategies
{
    public class RealQuotationStrategy : AbstractQuotationStrategy
    {
        public RealQuotationStrategy()
        {
            _quotationWebClientService = new RealQuotationWebClient();
        }

        public override QuotationResult GetQuotation()
        {
            return _quotationWebClientService.GetQuotation();
        }
    }
}
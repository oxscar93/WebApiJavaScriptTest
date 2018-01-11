using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.Services;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.QuotationStrategies
{
    public class PesosQuotationStrategy : AbstractQuotationStrategy
    {
        public PesosQuotationStrategy()
        {
            _quotationWebClientService = new PesosQuotationWebClient();
        }
        public override QuotationResult GetQuotation()
        {
            return _quotationWebClientService.GetQuotation();
        }
    }
}
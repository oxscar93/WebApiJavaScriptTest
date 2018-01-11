using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.Services;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.QuotationStrategies
{
    public abstract class AbstractQuotationStrategy
    {
        public IQuotationWebClient _quotationWebClientService;
        public abstract QuotationResult GetQuotation();
    }
}
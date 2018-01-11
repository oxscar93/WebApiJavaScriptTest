using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.QuotationStrategies;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public class QuotationService
    {   
        public QuotationResult GetQuotation(string currency)
        {
            return new QuotationStrategyFactory().GetQuotationStrategy(currency).GetQuotation();
        }
    }
}
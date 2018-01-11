using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.QuotationStrategies
{
    public class DefaultQuotationStrategy : AbstractQuotationStrategy
    {
        public override QuotationResult GetQuotation()
        {
            return new QuotationResult("Invalid Currency", HttpStatusCode.BadRequest);
        }
    }
}
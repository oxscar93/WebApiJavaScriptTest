using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public class RealQuotationWebClient : IQuotationWebClient
    {
        public QuotationResult GetQuotation()
        {
            return new QuotationResult(HttpStatusCode.Unauthorized);
        }
    }
}

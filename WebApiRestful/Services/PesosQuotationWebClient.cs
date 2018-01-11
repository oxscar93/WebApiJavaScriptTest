using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public class PesosQuotationWebClient : IQuotationWebClient
    {
        public QuotationResult GetQuotation()
        {
            return new QuotationResult(HttpStatusCode.Unauthorized);
        }
    }
}
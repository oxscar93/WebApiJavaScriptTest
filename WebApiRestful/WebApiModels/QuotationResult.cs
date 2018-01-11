using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApiRestful.WebApiModels
{
    public class QuotationResult
    {
        public HttpStatusCode Result;

        public string Message;

        public QuotationResult(string message, HttpStatusCode result)
        {
            Message = message;
            Result = result;
        }

        public QuotationResult(HttpStatusCode result)
        { 
            Result = result;
        }

        public QuotationResult()
        {
        }
    }
}
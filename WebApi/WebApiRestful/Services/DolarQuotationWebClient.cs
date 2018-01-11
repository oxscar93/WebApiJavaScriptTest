using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public class DolarQuotationWebClient : IQuotationWebClient
    {
        private WebClient _webClient;

        public DolarQuotationWebClient()
        {
            _webClient = new WebClient();
        }
        public QuotationResult GetQuotation()
        {
            try
            {
                using (_webClient)
                {
                    Stream data = _webClient.OpenRead("https://www.bancoprovincia.com.ar/Principal/Dolar");

                    StreamReader reader = new StreamReader(data);
                    return new QuotationResult(reader.ReadToEnd(), HttpStatusCode.OK);
                }
            }
            catch(Exception e)
            {
                return new QuotationResult(e.Message, HttpStatusCode.InternalServerError);
            }          
        }
    }
}

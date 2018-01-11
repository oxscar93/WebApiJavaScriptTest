using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public interface IQuotationWebClient
    {
        QuotationResult GetQuotation();
    }
}

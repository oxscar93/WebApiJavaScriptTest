using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebApiRestful.Factories;
using WebApiRestful.Services;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Controllers
{
    public class WebApiHomeController : ApiController
    {
        private UserService _userService;

        public WebApiHomeController()
        {
            _userService = UserServiceFactory.GetUserService();
        }

        [HttpGet]
        public IHttpActionResult GetQuotation(string currency)
        {
            var quotation = new QuotationResult();

            try
            {
                quotation = new QuotationService().GetQuotation(currency);
            }
            catch(Exception e)
            {
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message));
            }

            return new ResponseMessageResult(Request.CreateResponse(quotation.Result, quotation.Message));
        }

        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();

                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "Users : " + _SerializeObject(users)));
            }
            catch(Exception e)
            {
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message));
            }
        }

        [HttpPost]
        public IHttpActionResult UpdateUser(int id, UserJsonModel user)
        {
            try
            {
                _userService.UpdateUser(user, id);
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "User Updated"));

            }
            catch (Exception e)
            {
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message));
            }
        }

        [HttpPost]
        public IHttpActionResult CreateUser(UserJsonModel user)
        {
            try
            {
                _userService.CreateUser(user);
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "User Created"));

            }
            catch(Exception e)
            {
                new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message));
            }

            return null;
        }

        [HttpPost]
        public IHttpActionResult DeleteUser(int id)
        {
            try
            {
                _userService.DeleteUser(id);
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "User Deleted"));

            }
            catch (Exception e)
            {
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message));
            }
        }

        private string _SerializeObject(object value)
        {
            JsonSerializer serializer = new JsonSerializer();

            return JsonConvert.SerializeObject(value);
        }

    }
}

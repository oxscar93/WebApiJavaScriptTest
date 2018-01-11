using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.Services;

namespace WebApiRestful.Factories
{
    public static class UserServiceFactory
    {
        public static UserService GetUserService()
        {
            return new UserService(new Daos.UserDao(new UsersEntities()));
        }
    }
}
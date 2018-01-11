using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiRestful.Services;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Tests.Services
{
    [TestClass]
    public class UserServiceTest
    {
        private IUserEntitiesContext _context;
        private UserService _userService;

        [TestInitialize]
        public void Setup()
        {
            _context = new TestDbContext();
            _userService = new UserService(new Daos.UserDao(_context));
        }

        [TestMethod]
        public void TestCreateUser()
        {
            var user = new UserJsonModel();
            
            _userService.CreateUser(user);

            var users = _context.Users.Find();

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            var user = new UserJsonModel();

            user.Email = "11@gmail.com";

            _context.Users.Add(new WebApiRestful.User { UserId = 1 });

            _userService.UpdateUser(user, 1);

            var users = _context.Users.Find();

            Assert.IsNotNull(users);
        }


        [TestMethod]
        public void TestDeleteUser()
        {
            _context.Users.Add(new WebApiRestful.User { UserId = 1 });

            _userService.DeleteUser(1);

            var users = _context.Users.Find();

            Assert.IsNull(users);
        }
    }
}

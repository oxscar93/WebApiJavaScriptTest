using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestful.Daos;
using WebApiRestful.WebApiModels;

namespace WebApiRestful.Services
{
    public class UserService
    {
        private UserDao _userDao;

        public UserService(UserDao userDao)
        {
            _userDao = userDao;
        }

        public IList<User> GetAllUsers()
        {
            return _userDao.GetAllUsers();
        }

        public void CreateUser(UserJsonModel user)
        {
            _userDao.CreateUser(GetUserModel(user));
        }

        public void UpdateUser(UserJsonModel user, int id)
        {
            var userFromDb = GetUser(id);

            userFromDb.Email = user.Email;
            userFromDb.LastName = user.LastName;
            userFromDb.UserPassword = user.UserPassword;
            userFromDb.FirstName = user.FirstName;

            _userDao.UpdateUser(userFromDb);
        }

        public void DeleteUser(int id)
        {
            var userFromDb = GetUser(id);

            _userDao.DeleteUser(userFromDb);
        }

        private User GetUserModel(UserJsonModel user)
        {
            var userToSave = new User();
            userToSave.Email = user.Email;
            userToSave.FirstName = user.FirstName;
            userToSave.LastName = user.LastName;
            userToSave.UserPassword = user.UserPassword;

            return userToSave;
        }

        private User GetUser(int id)
        {
            var userFromDb = _userDao.GetUser(id);

            if (userFromDb == null) throw new Exception("User doesn't exists");

            return userFromDb;
        }
    }
}
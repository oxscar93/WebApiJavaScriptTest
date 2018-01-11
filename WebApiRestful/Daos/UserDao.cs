using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using WebApiRestful.Services;

namespace WebApiRestful.Daos
{
    public class UserDao
    {
        private IUserEntitiesContext _userEntities;

        public UserDao(IUserEntitiesContext entity)
        {
            _userEntities = entity;
        }

        public IList<User> GetAllUsers()
        {
            var userQuery = from d in _userEntities.Users select d;

            return userQuery.ToList();
        }

        public User GetUser(int id)
        {
            var userQuery = from d in _userEntities.Users where d.UserId == id select d;

            return userQuery.ToList().FirstOrDefault();
        }

        public void CreateUser(User user)
        {
            _userEntities.Users.Add(user);
            _userEntities.SaveChanges();
        }
        
        public void UpdateUser(User user)
        {
            _userEntities.MarkAsModified(user);
            _userEntities.SaveChanges();
            
        }

        public void DeleteUser(User user)
        {
            _userEntities.Users.Remove(user);
            _userEntities.SaveChanges();
        }
    }
}
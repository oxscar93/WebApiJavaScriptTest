using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRestful.Services;

namespace WebApiRestful.Tests.Services
{
    public class TestDbContext : IUserEntitiesContext
    {
        public TestDbContext()
        {
            this.Users = new TestUsersDbSet();
        }
        public DbSet<User> Users { get; set; }

        public void Dispose()
        {
     
        }

        public void MarkAsModified(User item)
        {
 
        }

        public int SaveChanges()
        {
            return 0;
        }
    }
}

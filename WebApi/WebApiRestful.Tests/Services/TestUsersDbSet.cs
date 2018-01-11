using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiRestful.Tests.Services
{
    public class TestUsersDbSet : TestDbSet<User>
    {
        public override User Find(params object[] keyValues)
        {
            if (keyValues.ToList<object>().Count == 0) return this.FirstOrDefault<User>();
            return this.SingleOrDefault(user => user.UserId == (int)keyValues.Single());
        }
    }
}

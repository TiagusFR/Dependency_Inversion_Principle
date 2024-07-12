using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal class UserRepository : IUserRepository
    {
        public string GetUser(int id)
        {
            //Any logic to get user from db
            return "User data";
        }
    }
}

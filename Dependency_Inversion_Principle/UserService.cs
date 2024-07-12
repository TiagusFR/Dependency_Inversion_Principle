using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void DisplayUser(int  userId)
        {
            var user = _userRepository.GetUser(userId);
            Console.WriteLine(user);
        }
    }
}

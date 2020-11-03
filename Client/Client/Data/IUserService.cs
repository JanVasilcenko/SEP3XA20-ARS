using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string email, string password);
        Task AddUser(User newUser);
    }
}

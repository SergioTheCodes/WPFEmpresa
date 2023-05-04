using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(Users user);
        List<Users> GetUsers();
        Users GetUsersByDNI(string DNI, int type);
    }
}

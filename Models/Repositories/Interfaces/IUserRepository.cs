using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Add(Users userModel);
        void Update(Users userModel);
        void Delete(string DNI);
        IEnumerable<Users> GetAll();
        IEnumerable<Users> GetByDNI(int type, string DNI);
    }
}

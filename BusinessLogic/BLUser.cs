using BusinessLogic.Interfaces;
using DataAccess.Repositories;
using Models;
using Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLUser : IBLUser
    {
        UserRepository userRepository = new UserRepository();
        public void AddUser(Users user)
        {
            try
            {
                userRepository.AddUser(user);
            }
            catch(Exception ex)
            {

            }
        }

        public void DeleteUser(Users user)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }

        public List<Users> GetUsers()
        {
            List<Users> UsersList = new List<Users>();
            try
            {
                UsersList = userRepository.GetUsers();
            }
            catch(Exception ex)
            {

            }
            return UsersList;
        }

        public Users GetUsersByDNI(string DNI, int type)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
            return null;
        }

        public void UpdateUser(Users user)
        {
            try
            {
                userRepository.UpdateUser(user);
            }catch(Exception ex)
            {

            }
        }
    }
}

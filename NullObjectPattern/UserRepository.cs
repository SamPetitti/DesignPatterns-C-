using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    


    public class UserRepository : IUserRepository
    {
        public static List Users = new List<User>(){
            new User{Name = "Sam", Id = 1, SessionTicket = 1},
            new User{Name = "Bridget", Id = 2, SessionTicket = 2}
        };
         public User GetById(int id){
            return Users.Where(u => u.Id = id);
         }
    }

    public interface IUserRepository
    {
        User GetById(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    


    public class UserRepository : IUserRepository
    {
        public static List<User>  Users = new List<User>(){
            new User{Name = "Sam", Id = 1, SessionTicket = 1},
            new User{Name = "Bridget", Id = 2, SessionTicket = 2}
        };
         public IUser GetById(int id){
            
            var user = Users.SingleOrDefault(u => u.Id == id);
            if(user == null){
                return new NonUser();
            }
            return user;
         }
    }

    public interface IUserRepository
    {
        IUser GetById(int id);
    }
}
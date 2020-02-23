using System;

namespace NullObjectPattern
{
    public class Program
    {
        static IUserRespository userRespository = new UserRespository();
        static void Main(string[] args)
        {
          var user = userRespository.GetById(id); 
          // without the Null Object pattern, this line could throw an exception  
          user.IncrementSessionTicket();
        }
    }
}

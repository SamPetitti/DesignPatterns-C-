using System;

namespace NullObjectPattern
{
    public class Program
    {
        static IUserRepository userRespository = new UserRepository();
        static void Main(string[] args)
        {
          var user = userRespository.GetById(1); 
          // without the Null Object pattern, this line could throw an exception  
          // user.IncrementSessionTicket();
          // so you would do something like this:
        //   if(user != null){
        //       user.IncrementSessionTicket();
        //   }
          // but the responsiblity for checking nulls should not be in the client of the service
          // it should be on the service.
          // which lets you go back to the original :
          user.IncrementSessionTicket();  
          Console.WriteLine($"User Id: {user.Id} and User Name: {user.Name}");
          Console.ReadLine();
        }
    }
}

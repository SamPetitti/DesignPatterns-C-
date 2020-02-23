using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class User : IUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SessionTicket { get; set; }

        public void IncrementSessionTicket(){
             this.SessionTicket += 1;
        }
    }

    public class NonUser : IUser 
    {
        public void IncrementSessionTicket(){
            
        }

        public int Id { get; set;}
        public string Name { get; set; }
        public int SessionTicket {get ; set;}
    }

    public interface IUser
    {
         void IncrementSessionTicket();

         int Id {get; set;}

         int SessionTicket {get ; set;}

         string Name { get; set ;}

    }
}
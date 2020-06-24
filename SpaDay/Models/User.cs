using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public int Id { get; }
        static private int nextId = 1;

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; }


        public User()
        {
            Id = nextId;
            nextId++;
        }

        public User(string username, string email, string password) : this()
        {
            Username = username;
            Email = email;
            Password = password;
            Date = DateTime.Today;
        }

        public override string ToString()
        {
            return Username;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClassDemo.Models
{
    public class UsersDB
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserDBContext : DbContext
    {
        public DbSet<UsersDB> User { get; set; }

    }
}
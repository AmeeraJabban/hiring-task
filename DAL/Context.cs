using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{

    public class Context : DbContext
    {
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options)
              : base(options)
        {
        }
       
        public DbSet<Account> Account { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }



    }
}
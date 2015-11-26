using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList04.Models
{
    public partial class ToDoContext : DbContext
    {
        public ToDoContext() : base("name=ToDoContext")
        {

        }
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
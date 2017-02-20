using SMSystem.Models;

namespace SMSystem.DBConnection
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SM_System : DbContext
    {
        public SM_System()
            : base("name=SM_System")
        {
        }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

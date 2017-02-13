using SMSystem.DBConnection;
using SMSystem.Models;

namespace SMSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAdminName : DbMigration
    {
        SM_System db = new SM_System();
        public override void Up()
        {
            db.Users.Add(new User()
            {
                Id = 1,
                UserName = "clive",
                Email = "clivekumara@gmail.com",
                PasswordHash = "1234",
                CreateDateTime = DateTime.Now,
                UserType = UserType.Admin,
                IsConformed = false,
                MobileNumber = "0718256773"

            });

            db.SaveChanges();
            db.Dispose();
        }
        
        public override void Down()
        {
        }
    }
}

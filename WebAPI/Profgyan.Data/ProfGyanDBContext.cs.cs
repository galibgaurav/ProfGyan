using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace Profgyan.Data
{
    public class ProfGyanUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        //{
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
        //    // Add custom user claims here
        //    return userIdentity;
        //}
    }

    public class ProfGyanDBContext : IdentityDbContext<ProfGyanUser>
    {
        public ProfGyanDBContext()
            : base("Data Source=IN-L20042\\SQLSERVER2014;Database=ProfGyanDB;Integrated Security=False;User ID=sa;Password=Password1;MultipleActiveResultSets=true;", throwIfV1Schema: false)
        {
        }

        //public ProfGyanDBContext()
        //    : base("Data Source=IN-L20042\\SQLSERVER2014;Database=ProfGyanDB;Integrated Security=False;User ID=sa;Password=Password1;MultipleActiveResultSets=true;", throwIfV1Schema: false)
        //{
        //} 
        public static ProfGyanDBContext Create()
        {
            return new ProfGyanDBContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //AspNetUsers -> User
            modelBuilder.Entity<ProfGyanUser>()
                .ToTable("User");
            //AspNetRoles -> Role
            modelBuilder.Entity<IdentityRole>()
                .ToTable("Role");
            //AspNetUserRoles -> UserRole
            modelBuilder.Entity<IdentityUserRole>()
                .ToTable("UserRole");
            //AspNetUserClaims -> UserClaim
            modelBuilder.Entity<IdentityUserClaim>()
                .ToTable("UserClaim");
            //AspNetUserLogins -> UserLogin
            modelBuilder.Entity<IdentityUserLogin>()
                .ToTable("UserLogin");
        }
    }
}

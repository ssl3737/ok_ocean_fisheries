namespace OkOceanFisheries.Migrations.AccountMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using OkOceanFisheries.Model.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OkOceanFisheries.Model.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AccountMigrations";
        }
        protected override void Seed(OkOceanFisheries.Model.Entities.ApplicationDbContext context)
        {
            //Initialize the managers/stores
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            // If role does not exists, create it
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }
            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new IdentityRole("User"));
            }

            // Create test users
            //Create administrator test user
            var adminUser = userManager.FindByName("admin");
            if (adminUser == null)
            {
                var newAdminUser = new ApplicationUser()
                {
                    UserName = "admin",
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var result = userManager.Create(newAdminUser, "admin123");
                if (result.Succeeded)
                {
                    userManager.SetLockoutEnabled(newAdminUser.Id, false);
                    userManager.AddToRole(newAdminUser.Id, "admin");
                }
            }

            // Create users called andy
            //Create administrator test user
            var andy = userManager.FindByName("andy");
            if (andy == null)
            {
                var newAndy = new ApplicationUser()
                {
                    UserName = "andy",
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var result = userManager.Create(newAndy, "P@$$w0rd");
                if (result.Succeeded)
                {
                    userManager.SetLockoutEnabled(newAndy.Id, false);
                    userManager.AddToRole(newAndy.Id, "User");
                }
            }
        }
       
    }
}

using Dim_Dat_Pro_2._0.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dim_Dat_Pro_2._0.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Supported_Roles.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Supported_Roles.Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Supported_Roles.Roles.Employee.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Supported_Roles.Roles.Guest.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "Administrator",
                Email = "Administrator@gmail.com",
                FirstName = "Super",
                LastName = "User",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Supported_Roles.Roles.Guest.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Supported_Roles.Roles.Employee.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Supported_Roles.Roles.Manager.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Supported_Roles.Roles.Administrator.ToString());
                }

            }
        }
    }
}

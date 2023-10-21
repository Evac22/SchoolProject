﻿using SchoolProject.Repositories;
using Microsoft.AspNetCore.Identity;
using SchoolProject.Models;
using Microsoft.EntityFrameworkCore;


namespace SchoolProject.Utilities
{
    public class DbInitializer : IDbInitializer
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        public DbInitializer(UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManeger, 
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManeger;
            _context = context;
        }

        public void Initialize()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count()>0)
                {
                    _context.Database.Migrate();
                }                                   
            }
            catch (Exception)
            {
                throw;
            }
            if(!_roleManager.RoleExistsAsync(WebSiteRole.WebSite_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Admin)).GetAwaiter().GetResult(); 
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Student)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRole.WebSite_Teacher)).GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com"
                }, "Admin@123").GetAwaiter().GetResult();
                var appuser = _userManager.Users.Where(x => x.Email == "admin@gmail.com").FirstOrDefault();
                if(appuser != null)
                {
                    _userManager.AddToRoleAsync(appuser, WebSiteRole.WebSite_Admin).GetAwaiter().GetResult();
                }
            }
        }
    }
}

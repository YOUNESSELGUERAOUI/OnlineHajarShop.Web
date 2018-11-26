using HajarShop.Security.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajarShop.Security.Service
{
    public class UserService : IUserService
    {
        private bool _initialized;
        private UserManager<ApplicationUser> _userManager;

        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            if (!_initialized)
            {
             //   _userManager = new UserManager<ApplicationUser, string>(new UserStore<ApplicationUser, CustomRole, string, CustomUserLogin, CustomUserRole, CustomUserClaim>(new myDbContext()));
                //_userManager = new UserManager<ApplicationUser, string>(
                //    new UserStore(
                //        new HajarShopIdentityContext(
                //            new DbContextOptions()));

                _initialized = true;
            }
        }
    }
}

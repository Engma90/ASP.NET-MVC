using Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity.Startup))]
namespace Identity
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
            CreateUsers();
        }


        public void CreateUsers()
        {
            var userManager = new UserManager<ApplicationUser>
                                (new UserStore<ApplicationUser>(db));
            ApplicationUser user;

            user = new ApplicationUser();
            user.UserName = "Admin";
            user.Email = "eng.ma90@hotmail.com";
            if (userManager.FindByName(user.UserName) == null)
            {
                var check = userManager.Create(user,"Mm@123456");
                if (check.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admins");
                }
            }


        }

        public void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>
                                (new RoleStore<IdentityRole>(db));
            IdentityRole role;

            role = new IdentityRole("Admins");
            if (!roleManager.RoleExists(role.Name))
            {
                roleManager.Create(role);
            }

            role = new IdentityRole("Authors");
            if (!roleManager.RoleExists(role.Name))
            {
                roleManager.Create(role);
            }

            role = new IdentityRole("Readers");
            if (!roleManager.RoleExists(role.Name))
            {
                roleManager.Create(role);
            }
            
        }
    }
}

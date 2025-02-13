using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaGestorPacientes.Infrastructure.Persistence.Seeders
{
    public static class IdentitySeeder
    {
        public static async Task SeedRolesAndAdmin(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var services = scope.ServiceProvider;
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

                string[] roles = { "Admin", "Usuario" };

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role));
                }

                string adminEmail = "admin@sistema.com";
                string adminPassword = "Admin123!";

                if (await userManager.FindByEmailAsync(adminEmail) == null)
                {
                    var adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail };
                    var result = await userManager.CreateAsync(adminUser, adminPassword);
                    if (result.Succeeded)
                        await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}

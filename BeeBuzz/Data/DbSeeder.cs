using BeeBuzz.Data.Entities;
using BeeBuzz.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class DbSeeder
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole<int>> _roleManager;

    public DbSeeder(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole<int>> roleManager)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task SeedAsync()
    {
        _context.Database.EnsureCreated();
        await SeedRolesAsync();
        await SeedOrganizationsAsync();
        await SeedUsersAsync();
    }

    private async Task SeedRolesAsync()
    {
        var roles = await LoadJsonAsync<List<string>>("Data/SeedData/Roles.json");
        foreach (var role in roles)
        {
            if (!await _roleManager.RoleExistsAsync(role))
            {
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = role });
            }
        }
    }

    private async Task SeedOrganizationsAsync()
    {
        var organizations = await LoadJsonAsync<List<Organization>>("Data/SeedData/Organizations.json");
        foreach (var organization in organizations)
        {
            if (!_context.Organizations.Any(o => o.Id == organization.Id))
            {
                _context.Organizations.Add(organization);
            }
        }
        await _context.SaveChangesAsync();
    }

    private async Task SeedUsersAsync()
    {
        var users = await LoadJsonAsync<List<ApplicationUser>>("Data/SeedData/Users.json");
        foreach (var user in users)
        {
            if (await _userManager.FindByEmailAsync(user.Email) == null)
            {
                var result = await _userManager.CreateAsync(user, "DefaultPassword@123");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Default");
                }
            }
        }
    }

    private async Task<T> LoadJsonAsync<T>(string filePath)
    {
        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<T>(json) ?? throw new InvalidOperationException($"Failed to deserialize JSON from {filePath}");
    }
}

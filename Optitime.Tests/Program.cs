using System.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

using Optitime.Classes;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

const string connectionString = "Host=localhost;Port=5433;Database=optitime;Username=postgres;Password=student";

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

using AppDbContext db = new(optionsBuilder.UseNpgsql(connectionString).Options);

Guid[] roleIds = [Guid.NewGuid(), Guid.NewGuid()];
Guid[] userIds = [Guid.NewGuid(), Guid.NewGuid()];

db.User.RemoveRange(db.User.ToList());
db.SaveChanges();

db.AppRole.RemoveRange(db.AppRole.ToList());
db.SaveChanges();


db.AppRole.Add(new ApplicationRole
{
    Id = roleIds[0],
    RoleName = "Admin"
});

db.AppRole.Add(new ApplicationRole
{
    Id = roleIds[1],
    RoleName = "User"
});

db.User.Add(new User
{
    Id = userIds[0],
    Login = "numberone",
    Name = "Matvey",
    LastName = "Liquid",
    Email = "rangung88@gmail.com",
    ApplicationRoleId = roleIds[0]
});


db.User.Add(new User
{
    Id = userIds[1],
    Login = "numbertwo",
    Name = "Ken",
    LastName = "Carson",
    Email = "umopi@gmail.com",
    ApplicationRoleId = roleIds[1]

});
byte[] pswd = Encoding.UTF8.GetBytes("password");
byte[] hash = SHA512.HashData(pswd);
string hex = BitConverter.ToString(hash).Replace("-", "");


db.UserPassword.Add(new UserPassword
{
    Id = Guid.NewGuid(),
    PasswordHash = hex,
    UserId = userIds[0]
});

db.SaveChanges();
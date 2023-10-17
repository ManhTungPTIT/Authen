using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Myproject.Models;

namespace Myproject.Data
{
    public class DBContext : IdentityDbContext
    {
        public DBContext(DbContextOptions options): base(options) { }
    }
}

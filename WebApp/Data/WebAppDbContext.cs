using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services
{
    public class UserService
    {
        private readonly WebAppDbContext _context;

        public UserService(WebAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> FindAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task CreateAsync(User user)
        {
             _context.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}

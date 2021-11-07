using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services
{
    public class SeedService
    {
        private readonly WebAppDbContext _context;

        public SeedService(WebAppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Users.Any())
            {
                return;
            }

            var u1 = new User(1, "João", "da Silva", "joao.silva@gmail.com", new DateTime(1998, 4, 24));
            var u2 = new User(2, "Maria", "Oliveira", "maria@gmail.com", new DateTime(1995, 10, 5));
            var u3 = new User(3, "Pedro Henrique", "Queiroz", "pedro.henrique@gmail.com", new DateTime(1995, 12, 17));
            var u4 = new User(4, "Yago", "da Silva", "yago.silva@gmail.com", new DateTime(1995, 10, 5));

            _context.AddRange(u1, u2, u3, u4);
            _context.SaveChanges();
        }
    }
}


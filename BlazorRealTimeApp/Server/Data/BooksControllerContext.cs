using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorRealTimeApp.Shared;

namespace BlazorRealTimeApp.Server.Data
{
    public class BooksControllerContext : DbContext
    {
        public BooksControllerContext (DbContextOptions<BooksControllerContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorRealTimeApp.Shared.Book> Book { get; set; } = default!;
    }
}

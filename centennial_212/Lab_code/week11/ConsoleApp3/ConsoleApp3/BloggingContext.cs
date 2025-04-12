using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlServer(@"Data Source=localhost;Database=Blogs;User ID=sa;Password=blogadmin;");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=Blogs;User ID=sa;Password=blogadmin;TrustServerCertificate=True;");
        }
    }
}


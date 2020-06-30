using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netcore_angular9_mariadb.Models;

namespace netcore_angular9_mariadb.Data
{
    public class BlogPostsContext : DbContext
    {
        public BlogPostsContext (DbContextOptions<BlogPostsContext> options)
            : base(options)
        {
        }

        public DbSet<netcore_angular9_mariadb.Models.BlogPost> BlogPost { get; set; }
    }
}

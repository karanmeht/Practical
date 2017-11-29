using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPaperSubscribe.Models
{
    public class NewsPaperDbContext : DbContext
    {
        public NewsPaperDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClientDetails> ClientDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzyOracle.Model
{
    public class VidzyDbContext : DbContext
    {
        public DbSet<Video> Courses { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyDbContext() : base("VidzyDbContext")
        {

        }
    }
}

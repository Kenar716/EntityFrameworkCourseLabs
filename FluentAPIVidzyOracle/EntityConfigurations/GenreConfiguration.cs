using CodeFirstVidzyOracle.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzyOracle.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            //Table Overwrites

            //Primary Keys Overwrites

            //Properties Configuration (sort alphabetically)
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            //RelationsShips
        }
    }
}

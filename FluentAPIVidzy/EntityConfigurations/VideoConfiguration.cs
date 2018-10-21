using FluentAPIVidzy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIVidzy.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            //Table Overwrites

            //Primary Keys Overwrites

            //Properties Configuration (sort alphabetically)
            Property(v => v.GenreId)
                .IsRequired()
                .HasColumnName("GenreId");

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.ClassificationType)
                .HasColumnType("tinyint");

            //RelationsShips
        }
    }
}

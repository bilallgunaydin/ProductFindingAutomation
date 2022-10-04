using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mapping
{
    class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(p => p.ProductId).Property(p => p.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ProductName)
                .HasColumnType("varchar(max)")
                .IsRequired()
                .HasMaxLength(Int32.MaxValue);
            Property(p => p.Price)
                .HasColumnType("varchar(max)")
                .HasMaxLength(Int32.MaxValue)
                .IsOptional();
            Property(p => p.SiteName)
                .HasColumnType("varchar(max)")
                .IsRequired()
                .HasMaxLength(Int32.MaxValue);
            Property(p => p.ListDate)
                .HasColumnType("datetime")
                .IsRequired();
            Property(p => p.Keyword)
                .HasColumnType("varchar(max)")
                .IsOptional()
                .HasMaxLength(Int32.MaxValue);

        }
    }
}

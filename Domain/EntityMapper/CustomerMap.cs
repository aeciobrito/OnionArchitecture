using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntityMapper
{
    internal class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p => p.Id)
                .HasName("pk_customerid");

            builder.Property(p => p.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");

            builder.Property(p => p.PurchasesProduct)
                .HasColumnName("purchased_product")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder.Property(x => x.PaymentType)
               .HasColumnName("payment_type")
                  .HasColumnType("NVARCHAR(50)")
                  .IsRequired();

            builder.Property(x => x.CreatedDate)
              .HasColumnName("created_date")
              .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
              .HasColumnName("modified_date")
              .HasColumnType("datetime");

            builder.Property(x => x.IsActive)
              .HasColumnName("is_active")
              .HasColumnType("bit");
        }
    }
}

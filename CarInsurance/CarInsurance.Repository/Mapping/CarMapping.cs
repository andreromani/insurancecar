using CarInsurance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Repository.Mapping
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("CAR");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("ID")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(c => c.ValueCar)
                .HasColumnName("VALUECAR");

            builder.Property(c => c.Brand)
                .HasColumnName("BRAND")
                .HasMaxLength(100);
        }
    }
}

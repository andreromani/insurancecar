using CarInsurance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarInsurance.Repository.Mapping
{
    public class InsuranceMapping : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("INSURANCE");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("ID")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(i => i.InsurancePrice)
                .HasColumnName("INSURANCEPRICE");

            builder.Property(i => i.InsuredId)
               .HasColumnName("INSUREDID")
               .IsRequired();

            builder.Property(i => i.CarId)
               .HasColumnName("CARID")
               .IsRequired();           

            builder.HasOne(i => i.Insured)
                   .WithMany().HasForeignKey(fk => fk.InsuredId);

            builder.HasOne(c => c.Car).WithMany()
               .HasForeignKey(fk => fk.CarId);           
        }
    }
}

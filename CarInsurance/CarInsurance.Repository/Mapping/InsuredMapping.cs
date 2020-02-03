using CarInsurance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarInsurance.Repository.Mapping
{
    public class InsuredMapping : IEntityTypeConfiguration<Insured>
    {
        public void Configure(EntityTypeBuilder<Insured> builder)
        {
            builder.ToTable("INSURED");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("ID")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Name)
                .HasColumnName("NAME")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.Cpf)
                .HasColumnName("CPF")
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(i => i.Age)
                .HasColumnName("AGE")
                .IsRequired();        
        }
    }
}

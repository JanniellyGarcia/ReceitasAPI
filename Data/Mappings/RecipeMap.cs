using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Receitas");

            builder.HasKey(prop => prop.id);

            builder.Property(prop => prop.title)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired() 
                .HasColumnName("Titulo") 
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.ingredients)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Ingredientes")
               .HasColumnType("varchar(100)"); 
        }
    }
}

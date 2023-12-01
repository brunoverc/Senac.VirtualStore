﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Infra.Data.Mapping
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //Nome da minha tabela
            builder.ToTable("Address");
            //Defini o tamanho máximo para 100 e informei que ele não aceita nulo
            builder.Property(a => a.Street).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Complement).HasMaxLength(100);
            builder.Property(a => a.Neighborhood).HasMaxLength(50).IsRequired();
            builder.Property(a => a.PostalCode).HasMaxLength(9);
            builder.Property(a => a.City).HasMaxLength(40).IsRequired();
            builder.Property(a => a.State).HasMaxLength(2);
        }

    }
}

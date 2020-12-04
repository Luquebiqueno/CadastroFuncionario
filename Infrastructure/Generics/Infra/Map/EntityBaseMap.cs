using Generics.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Infra.Map
{
    public abstract class EntityBaseMap<TEntity> : IEntityTypeConfiguration<TEntity>
                 where TEntity : EntityBase
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ativo)
                   .IsRequired();

            builder.Property(x => x.UsuarioCadastro)
                   .IsRequired();

            builder.Property(x => x.DataCadastro)
                   .IsRequired();

            builder.Property(x => x.UsuarioAlteracao);
            builder.Property(x => x.DataAlteracao);

            ConfigurarMapeamento(builder);
        }

        protected abstract void ConfigurarMapeamento(EntityTypeBuilder<TEntity> builder);

    }
}

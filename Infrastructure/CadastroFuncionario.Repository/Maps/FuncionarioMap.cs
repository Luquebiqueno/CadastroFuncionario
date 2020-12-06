using CadastroFuncionario.Domain.Entities;
using Generics.Infra.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Repository.Maps
{
    public class FuncionarioMap : EntityBaseMap<Funcionario>
    {
        protected override void ConfigurarMapeamento(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario", "dbo");
            builder.HasKey(e => e.Id).HasName("FuncionarioId");
            builder.Property(e => e.Id).HasColumnName("FuncionarioId").IsRequired().ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(128).IsRequired();
            builder.Property(e => e.Sobrenome).HasColumnName("Sobrenome").HasColumnType("varchar").HasMaxLength(128).IsRequired();
            builder.Property(e => e.DataNascimento).HasColumnName("DataNascimento").HasColumnType("datetime").IsRequired();
            builder.Property(e => e.Email).HasColumnName("Email").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired();
            builder.Property(e => e.Sexo).HasColumnName("SexoId").HasColumnType("int").IsRequired();
            builder.Property(e => e.Habilidade).HasColumnName("HabilidadeId").HasColumnType("int").IsRequired();

            builder.Ignore(e => e.DataCadastro);
            builder.Ignore(e => e.UsuarioCadastro);
            builder.Ignore(e => e.DataAlteracao);
            builder.Ignore(e => e.UsuarioAlteracao);
        }
    }
}

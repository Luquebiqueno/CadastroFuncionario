using CadastroFuncionario.Repository.Maps;
using Generics.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Repository.Context
{
    public class CadastroFuncionarioContext : ContextBase<CadastroFuncionarioContext>
    {
        public CadastroFuncionarioContext(DbContextOptions<CadastroFuncionarioContext> options) : base(options)
        {
        }

        public new int Commit() => this.SaveChanges();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }
    }
}

using CadastroFuncionario.Domain.Entities;
using CadastroFuncionario.Domain.Enums;
using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Domain.Interfaces.Service
{
    public interface IFuncionarioService<TContext> : IServiceBase<TContext, Funcionario>
                                    where TContext : IUnitOfWork<TContext>
    {
        IEnumerable<Funcionario> GetFuncionarioByIdade(int idade);
        IEnumerable<Funcionario> GetFuncionarioBySexo(string sexo);
        IEnumerable<Funcionario> GetFuncionarioByHabilidade(Habilidade habilidade);
        IEnumerable<Funcionario> GetFuncionarioByNome(string nome);
        public Funcionario UpdateFuncionario(int id, Funcionario entity);
    }
}

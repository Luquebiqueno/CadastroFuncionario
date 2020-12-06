using CadastroFuncionario.Domain.Entities;
using CadastroFuncionario.Domain.Enums;
using CadastroFuncionario.Domain.Interfaces.Repository;
using Generics.Domain.Interfaces;
using Generics.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroFuncionario.Repository.Repositories
{
    public class FuncionarioRepository<TContext> : RepositoryBase<TContext, Funcionario>, IFuncionarioRepository<TContext>
                                  where TContext : IUnitOfWork<TContext>
    {
        public FuncionarioRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }

        public IEnumerable<Funcionario> GetFuncionarioByHabilidade(Habilidade habilidade) => _dbSet.Where(x => x.Habilidade.Equals(habilidade)).ToList();

        public IEnumerable<Funcionario> GetFuncionarioByIdade(int idade) => _dbSet.Where(x => x.Idade.Equals(idade)).ToList();

        public IEnumerable<Funcionario> GetFuncionarioByNome(string nome) => _dbSet.Where(x => x.Nome.Contains(nome) || x.Sobrenome.Contains(nome)).ToList();

        public IEnumerable<Funcionario> GetFuncionarioBySexo(Sexo sexo) => _dbSet.Where(x => x.Sexo.Equals(sexo)).ToList();
    }
}

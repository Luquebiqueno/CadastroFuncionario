using CadastroFuncionario.Domain.Entities;
using CadastroFuncionario.Domain.Enums;
using CadastroFuncionario.Domain.Interfaces.Repository;
using CadastroFuncionario.Domain.Interfaces.Service;
using Generics.Domain.Interfaces;
using Generics.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroFuncionario.Domain.Services
{
    public class FuncionarioService<TContext> : ServiceBase<TContext, Funcionario>, IFuncionarioService<TContext>
                               where TContext : IUnitOfWork<TContext>
    {
        private new readonly IFuncionarioRepository<TContext> _repository;
        public FuncionarioService(IFuncionarioRepository<TContext> repository) : base(repository)
        {
            _repository = repository;
        }
        public IEnumerable<Funcionario> GetFuncionarioByHabilidade(Habilidade habilidade) => _repository.GetFuncionarioByHabilidade(habilidade);

        public IEnumerable<Funcionario> GetFuncionarioByIdade(int idade) => _repository.GetFuncionarioByIdade(idade);

        public IEnumerable<Funcionario> GetFuncionarioByNome(string nome) => _repository.GetFuncionarioByNome(nome);

        public IEnumerable<Funcionario> GetFuncionarioBySexo(Sexo sexo) => _repository.GetFuncionarioBySexo(sexo);

        public Funcionario UpdateFuncionario(int id, Funcionario entity)
        {
            var funcionario = _repository.Exists(id);

            funcionario.Idade = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(entity.DataNascimento.ToString("yyyy"));

            funcionario.AtualizarNome(entity.Nome);
            funcionario.AtualizarSobrenome(entity.Sobrenome);
            funcionario.AtualizarDataNascimento(entity.DataNascimento);
            funcionario.AtualizarSexo(entity.Sexo);
            funcionario.AtualizarHabilidade(entity.Habilidade);
            funcionario.AtualizarEmail(entity.Email);

            return base.Update(funcionario);
        }

        public override Funcionario Create(Funcionario entity)
        {
            entity.Idade = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(entity.DataNascimento.ToString("yyyy"));
            entity.Ativar();
            return base.Create(entity);
        }

        public void AtivarFuncionario(int id)
        {
            var funcionario = _repository.Exists(id);

            if (funcionario != null)
            {
                if(!funcionario.Ativo)
                    funcionario.Ativar();
            }

            base.Update(funcionario);
        }

        public void InativarFuncionario(int id)
        {
            var funcionario = _repository.Exists(id);

            if (funcionario != null)
            {
                if (funcionario.Ativo)
                    funcionario.Inativar();
            }

            base.Update(funcionario);
        }
    }
}

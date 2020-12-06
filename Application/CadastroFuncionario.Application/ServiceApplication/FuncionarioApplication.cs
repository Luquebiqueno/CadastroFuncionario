using CadastroFuncionario.Domain.Entities;
using CadastroFuncionario.Domain.Enums;
using CadastroFuncionario.Domain.Interfaces.Application;
using CadastroFuncionario.Domain.Interfaces.Service;
using Generics.Application;
using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Application.ServiceApplication
{
    public class FuncionarioApplication<TContext> : ApplicationBase<TContext, Funcionario>, IFuncionarioApplication<TContext>
                                   where TContext : IUnitOfWork<TContext>
    {
        private new readonly IFuncionarioService<TContext> _service;
        public FuncionarioApplication(IUnitOfWork<TContext> context, IFuncionarioService<TContext> service) : base(context, service)
        {
            _service = service;
        }

        public IEnumerable<Funcionario> GetFuncionarioByHabilidade(Habilidade habilidade) => _service.GetFuncionarioByHabilidade(habilidade);

        public IEnumerable<Funcionario> GetFuncionarioByIdade(int idade) => _service.GetFuncionarioByIdade(idade);

        public IEnumerable<Funcionario> GetFuncionarioByNome(string nome) => _service.GetFuncionarioByNome(nome);

        public IEnumerable<Funcionario> GetFuncionarioBySexo(Sexo sexo) => _service.GetFuncionarioBySexo(sexo);

        public Funcionario UpdateFuncionario(int id, Funcionario entity)
        {
            _service.UpdateFuncionario(id, entity);
            _unitOfWork.Commit();

            return entity;
        }

        public void AtivarFuncionario(int id)
        {
            _service.AtivarFuncionario(id);
            _unitOfWork.Commit();
        }

        public void InativarFuncionario(int id)
        {
            _service.InativarFuncionario(id);
            _unitOfWork.Commit();
        }
    }
}

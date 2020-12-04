using CadastroFuncionario.Domain.Enums;
using Generics.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Domain.Entities
{
    public class Funcionario : EntityBase
    {
        #region [ Propriedades ]

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public Habilidade Habilidade { get; set; }

        #endregion

        #region [ Construtores ]

        public Funcionario(string nome, string sobrenome, DateTime dataNascimento, string sexo, Habilidade habilidade)
        {
            this.AtualizarNome(nome);
            this.AtualizarSobrenome(sobrenome);
            this.AtualizarDataNascimento(dataNascimento);
            this.AtualizarSexo(sexo);
            this.AtualizarHabilidade(habilidade);
        }

        #endregion

        #region [ Métodos ]

        public void AtualizarNome(string nome) => this.Nome = nome;
        public void AtualizarSobrenome(string sobrenome) => this.Sobrenome = sobrenome;
        public void AtualizarDataNascimento(DateTime dataNascimento) => this.DataNascimento = dataNascimento;
        public void AtualizarSexo(string sexo) => this.Sexo = sexo;
        public void AtualizarHabilidade(Habilidade habilidade) => this.Habilidade = habilidade;
        public void AtualizarEmail(string email) => this.Email = email;

        #endregion
    }
}

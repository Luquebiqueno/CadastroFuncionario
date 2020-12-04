using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain.Entity
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? UsuarioCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? UsuarioAlteracao { get; set; }
        public bool Ativo { get; set; }

        public virtual void AtualizarDataCadastro() => this.DataCadastro = DateTime.Now;
        public virtual void AtualizarDataAlteracao() => this.DataAlteracao = DateTime.Now;
        public virtual void AtualizarUsuarioCadastro(int? usuarioCadastro) => this.UsuarioCadastro = usuarioCadastro;
        public virtual void AtualizarUsuarioAlteracao(int? usuarioAlteracao) => this.UsuarioAlteracao = usuarioAlteracao;
        public virtual void Ativar() => this.Ativo = true;
        public virtual void Inativar() => this.Ativo = false;
    }
}

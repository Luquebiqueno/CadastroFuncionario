using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Domain.Dto
{
    public class FuncionarioEditDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Habilidade { get; set; }
        public bool Ativo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Domain.Dto
{
    public class FuncionarioDto
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Habilidade { get; set; }
    }
}

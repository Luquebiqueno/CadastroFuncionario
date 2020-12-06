using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CadastroFuncionario.Domain.Enums
{
    public enum Sexo : int
    {
        [Display(Name = "Masculino")]
        Masculino = 1,

        [Display(Name = "Femenino")]
        Femenino = 2,

        [Display(Name = "Outro")]
        Outro = 3,
    }
}

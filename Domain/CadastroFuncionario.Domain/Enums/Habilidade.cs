using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CadastroFuncionario.Domain.Enums
{
    public enum Habilidade : int
    {
        [Display(Name = "CSharp")]
        CSharp = 1,

        [Display(Name = "Java")]
        Java = 2,

        [Display(Name = "Angular")]
        Angular = 3,

        [Display(Name = "SQL")]
        SQL = 4,

        [Display(Name = "ASP")]
        ASP = 5,
    }
}

using AutoMapper;
using CadastroFuncionario.Domain.Dto;
using CadastroFuncionario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionario.Api.AutoMapper
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<Funcionario, FuncionarioDto>()
            .ForMember(e => e.Nome, m => m.MapFrom(y => y.Nome + " " + y.Sobrenome))
            .ForMember(e => e.DataNascimento, m => m.MapFrom(y => y.DataNascimento))
            .ForMember(e => e.Idade, m => m.MapFrom(y => y.Idade))
            .ForMember(e => e.Email, m => m.MapFrom(y => y.Email))
            .ForMember(e => e.Sexo, m => m.MapFrom(y => y.Sexo))
            .ForMember(e => e.Habilidade, m => m.MapFrom(y => y.Habilidade))
            .ForAllOtherMembers(x => x.Ignore());
        }
    }
}

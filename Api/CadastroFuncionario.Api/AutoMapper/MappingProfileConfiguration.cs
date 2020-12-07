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
            .ForMember(e => e.Id, m => m.MapFrom(y => y.Id))
            .ForMember(e => e.Nome, m => m.MapFrom(y => y.Nome + " " + y.Sobrenome))
            .ForMember(e => e.DataNascimento, m => m.MapFrom(y => y.DataNascimento))
            .ForMember(e => e.Idade, m => m.MapFrom(y => y.Idade))
            .ForMember(e => e.Email, m => m.MapFrom(y => y.Email))
            .ForMember(e => e.Sexo, m => m.MapFrom(y => y.Sexo))
            .ForMember(e => e.Habilidade, m => m.MapFrom(y => y.Habilidade))
            .ForMember(e => e.Ativo, m => m.MapFrom(y => y.Ativo))
            .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Funcionario, FuncionarioEditDto>()
            .ForMember(e => e.Id, m => m.MapFrom(y => y.Id))
            .ForMember(e => e.Nome, m => m.MapFrom(y => y.Nome))
            .ForMember(e => e.Sobrenome, m => m.MapFrom(y => y.Sobrenome))
            .ForMember(e => e.DataNascimento, m => m.MapFrom(y => y.DataNascimento))
            .ForMember(e => e.Idade, m => m.MapFrom(y => y.Idade))
            .ForMember(e => e.Email, m => m.MapFrom(y => y.Email))
            .ForMember(e => e.Sexo, m => m.MapFrom(y => y.Sexo))
            .ForMember(e => e.Habilidade, m => m.MapFrom(y => y.Habilidade))
            .ForMember(e => e.Ativo, m => m.MapFrom(y => y.Ativo))
            .ForAllOtherMembers(x => x.Ignore());
        }
    }
}

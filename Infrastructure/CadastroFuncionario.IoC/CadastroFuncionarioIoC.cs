using CadastroFuncionario.Application.ServiceApplication;
using CadastroFuncionario.Domain.Interfaces.Application;
using CadastroFuncionario.Domain.Interfaces.Repository;
using CadastroFuncionario.Domain.Interfaces.Service;
using CadastroFuncionario.Domain.Services;
using CadastroFuncionario.Repository.Context;
using CadastroFuncionario.Repository.Repositories;
using Generics.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.IoC
{
    public class CadastroFuncionarioIoC
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork<CadastroFuncionarioContext>, CadastroFuncionarioContext>();

            //Repository
            services.AddScoped(typeof(IFuncionarioRepository<>), typeof(FuncionarioRepository<>));

            //Service
            services.AddScoped(typeof(IFuncionarioService<>), typeof(FuncionarioService<>));

            //Application
            services.AddScoped(typeof(IFuncionarioApplication<>), typeof(FuncionarioApplication<>));

        }
    }
}

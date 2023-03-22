using AntaresSystemWeb.Repository.Implementations;
using AntaresSystemWeb.Repository.Interfaces;
using AntaresSystemWeb.Services.Implementations;
using AntaresSystemWeb.Services.Interfaces;
using AntaresSystemWeb.Util;
using Blazored.Toast;
using Domain.Validations;
using Domain.ViewModel;
using FluentValidation;

namespace AntaresSystemWeb.Data.Dependencies
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<ICargoRepository, CargoRepository>();
            service.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            service.AddScoped<ICargoService, CargoService>();
            service.AddScoped<IFuncionarioService, FuncionarioService>();

            service.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            service.AddScoped<AuthenticatedUser>();

            #region Validation

            service.AddTransient<IValidator<CargoViewModel>, CargoValidation>();
            service.AddTransient<IValidator<FuncionarioViewModel>, FuncionarioValidation>();

            service.AddBlazoredToast();

            #endregion Validation

            return service;
        }
    }
}
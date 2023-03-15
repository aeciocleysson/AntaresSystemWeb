﻿using AntaresSystemWeb.Repository.Implementations;
using AntaresSystemWeb.Repository.Interfaces;
using AntaresSystemWeb.Services.Implementations;
using AntaresSystemWeb.Services.Interfaces;
using AntaresSystemWeb.Util;
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

            service.AddScoped<ICargoService, CargoService>();

            service.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            service.AddScoped<AuthenticatedUser>();

            #region Validation

            service.AddTransient<IValidator<CargoViewModel>, CargoValidation>();

            #endregion Validation

            return service;
        }
    }
}
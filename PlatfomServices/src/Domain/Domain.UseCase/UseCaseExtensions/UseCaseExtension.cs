using Domain.UseCase.Interfaces;
using Domain.UseCase.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.UseCase.UseCaseExtensions;

public static class UseCaseExtension
{
    public static IServiceCollection AddServicesUseCase(this IServiceCollection services)
    {
        services.AddTransient<IPlatformUseCase, PlatformUseCase>();
        return services;
    }
}
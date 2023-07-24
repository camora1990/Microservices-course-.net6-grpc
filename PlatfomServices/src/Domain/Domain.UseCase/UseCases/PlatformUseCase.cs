using Domain.Model.Models;
using Domain.Model.Repositories;
using Domain.UseCase.Interfaces;

namespace Domain.UseCase.UseCases;

public class PlatformUseCase : IPlatformUseCase
{
    private readonly IPlatformRespository _respository;

    public PlatformUseCase(IPlatformRespository respository)
    {
        _respository = respository;
    }

    public async Task<Platform> Create(Platform platform)
    {
        return await _respository.CreateAsync(platform);
    }

    public async Task<IEnumerable<Platform>> GetAll()
    {
        return await _respository.GetAllAsync();
    }

    public async Task<Platform> GetById(long id)
    {
        return await _respository.GetByIdAsync(id);
    }
}
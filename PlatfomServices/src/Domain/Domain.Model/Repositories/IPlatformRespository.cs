using Domain.Model.Models;

namespace Domain.Model.Repositories;

public interface IPlatformRespository
{
    Task<IEnumerable<Platform>> GetAllAsync();

    Task<Platform> GetByIdAsync(long id);

    Task<Platform> CreateAsync(Platform platform);
}
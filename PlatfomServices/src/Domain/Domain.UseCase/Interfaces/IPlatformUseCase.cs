using Domain.Model.Models;

namespace Domain.UseCase.Interfaces;

public interface IPlatformUseCase
{
    Task<IEnumerable<Platform>> GetAll();

    Task<Platform> GetById(long id);

    Task<Platform> Create(Platform platform);
}
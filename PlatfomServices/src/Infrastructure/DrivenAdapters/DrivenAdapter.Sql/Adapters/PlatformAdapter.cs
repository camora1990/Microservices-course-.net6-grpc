using Domain.Model.Models;
using Domain.Model.Repositories;
using DrivenAdapter.Sql.Context;
using Microsoft.EntityFrameworkCore;

namespace DrivenAdapter.Sql.Adapters;

public class PlatformAdapter : IPlatformRespository
{
    private readonly PlatformContext _context;

    public PlatformAdapter(PlatformContext context)
    {
        _context = context;
    }

    public async Task<Platform> CreateAsync(Platform platform)
    {
        _context.Add(platform);
        await _context.SaveChangesAsync();
        return platform;
    }

    public async Task<IEnumerable<Platform>> GetAllAsync()
    {
        return await _context.Platfoms.ToArrayAsync();
    }

    public async Task<Platform> GetByIdAsync(long id)
    {
        return await _context.Platfoms.FirstOrDefaultAsync(p => p.Id == id);
    }
}
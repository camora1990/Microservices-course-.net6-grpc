using AutoMapper;
using Domain.UseCase.Interfaces;
using EntryPoint.Web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EntryPoint.Web.Controllers;

public class PlatformController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IPlatformUseCase _useCase;

    public PlatformController(IMapper mapper, IPlatformUseCase useCase)
    {
        _mapper = mapper;
        _useCase = useCase;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => await HandleRequest(async () =>
             _mapper.Map<IEnumerable<PlatformDto>>(await _useCase.GetAll())
       , "List platform");
}
using AutoMapper;
using Domain.Model.Models;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] long id)
        => await HandleRequest(async () =>
        _mapper.Map<PlatformDto>(await _useCase.GetById(id)), "Platform");

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePlatformDto dto)
        => await HandleRequest(async () =>
        {
            var resp = await _useCase.Create(_mapper.Map<Platform>(dto));
            return _mapper.Map<PlatformDto>(resp);
        }, "");
}
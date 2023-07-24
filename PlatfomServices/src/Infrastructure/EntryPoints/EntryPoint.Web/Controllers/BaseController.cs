using Microsoft.AspNetCore.Mvc;

namespace EntryPoint.Web.Controllers;

[ApiController]
[Route("api/v1/[Controller]/[Action]")]
public class BaseController : ControllerBase
{
    public async Task<IActionResult> HandleRequest<TResult>(Func<Task<TResult>> requestHandler, string message)
    {
        var resp = await requestHandler();
        try
        {
            return Ok(new { message, ok = true, data = resp });
        }
        catch (Exception e)
        {
            return BadRequest(new { message = e.Message, ok = false });
        }
    }
}
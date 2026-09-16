using Microsoft.AspNetCore.Mvc;

namespace AzureDevOpsDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JournalController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Message = "Journal retrieved successfully"
        });
    }
}
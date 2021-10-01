using Microsoft.AspNetCore.Mvc;
namespace EStudy.Web.Controllers.API
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {

    }
}
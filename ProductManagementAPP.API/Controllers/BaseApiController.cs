/*
 * BaseApiController: 
 *  - path setting, and enable ApiController validation [ApiController]
 */

namespace ProductManagementAPP.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        List<string> test = new List<string>();
    }
}

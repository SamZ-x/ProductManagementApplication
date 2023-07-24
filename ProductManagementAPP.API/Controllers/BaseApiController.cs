/*
 * BaseApiController: 
 *  - path setting, and enable ApiController validation [ApiController]
 */

namespace ProductManagementApp.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}

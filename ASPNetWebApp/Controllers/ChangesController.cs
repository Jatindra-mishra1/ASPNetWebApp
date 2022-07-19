using Microsoft.AspNetCore.Mvc;

namespace ASPNetWebApp.Controllers
{
    [ApiController]
    [Route("api/changes")]
    public class ChangesController : ControllerBase
    {
        private readonly String _context;
        public ChangesController()
        {
            _context = null;
        }
    }
}

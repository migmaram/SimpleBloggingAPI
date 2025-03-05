using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBloggingAPI.Data;

namespace SimpleBloggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private ApiDbContext _context;
        public PostsController(ApiDbContext conte)
        {
            
        }
    }
}

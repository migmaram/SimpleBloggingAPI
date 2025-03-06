using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBloggingAPI.Data;
using SimpleBloggingAPI.Models;
using Tools;

namespace SimpleBloggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Post post)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.Posts.Add(post);
            _unitOfWork.Save();

            return Ok();
        }
    }
}

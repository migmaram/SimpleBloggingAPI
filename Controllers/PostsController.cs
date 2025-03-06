using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _unitOfWork.Posts.Get(id);
            if (post == null)
                return NotFound();

            return Ok(post);
        }
        [HttpGet]
        public IActionResult Get(string? term)
        {
            var posts =  string.IsNullOrWhiteSpace(term) ? 
                _unitOfWork.Posts.Get() :
                _unitOfWork.Posts.Get()
                .Where(p => 
                p.Title.Contains(term) ||
                p.Content.Contains(term) ||
                p.Category.Contains(term) ||
                p.Tags.Contains(term)
                ).ToList();

            return Ok(posts);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Post post)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.Posts.Add(post);
            _unitOfWork.Save();

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Post post)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var exsitingPost = _unitOfWork.Posts.Get(id);

            exsitingPost.Title = post.Title;
            exsitingPost.Content = post.Content;
            exsitingPost.Category = post.Category;
            exsitingPost.Tags = post.Tags;
            exsitingPost.UpdatedAt = DateTime.Now;

            _unitOfWork.Posts.Update(exsitingPost);
            _unitOfWork.Save();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingPost = _unitOfWork.Posts.Get(id);
            if (existingPost == null)
                return NotFound();

            _unitOfWork.Posts.Delete(id);
            return NoContent();
        }
    }
}

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

            var categories = _unitOfWork.Categories.Get();
            var category = categories.FirstOrDefault(c => c.Name == post.Category.Name);

            if ()
            {

            }

            //var tags = _unitOfWork.Tags.Get();

            //foreach (var tag in tags)
            //{

            //    if (!post.Tags.Contains(tag))
            //    {
            //        var newTag = new Tag { Name = "Fascism" };
            //        _unitOfWork.Tags.Add(newTag);

            //    }

            //}

            //if (category == null)
            //{
            //    //TODO: Create post view model to be able to add a category name as a string
            //    // because right now we're not able to do it, as the main post model
            //    // doesn't have a field to store a category name
            //    _unitOfWork.Categories.Add(new Category { Name = "Politcs" });
            //}

            _unitOfWork.Posts.Add(post);
            _unitOfWork.Save();

            return Ok();
        }
    }
}

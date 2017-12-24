using ForumApp.Application.Service.Interfaces;
using ForumApp.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TechProjecct.ForumApp.Api.Controllers
{
    [RoutePrefix("posts")]
    public class PostController : ApiController
    {
        private readonly IPostAppService _postAppService;
        public PostController(IPostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        // GET: posts
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Post>> Get()
        {
            return await _postAppService.GetAllAsync();
        }

        // GET: posts/5
        [Route("id:int")]
        [HttpGet]
        public async Task<Post> Get(int id)
        {
            return await _postAppService.GetAsync(id);
        }

        // POST: posts
        [Route("")]
        [HttpPost]
        public void Post([FromBody]Post value)
        {
            _postAppService.Add(value);
        }

        // PUT: posts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: posts/5
        [Route("id:int")]
        [HttpDelete]
        public void Delete(int id)
        {
            _postAppService.Remove(id);
        }
    }
}

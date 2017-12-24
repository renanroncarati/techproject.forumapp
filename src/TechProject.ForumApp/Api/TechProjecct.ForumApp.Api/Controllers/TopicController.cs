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
    [RoutePrefix("topics")]
    public class TopicController : ApiController
    {
        private readonly ITopicAppService _topicAppService;

        public TopicController(ITopicAppService topicAppService)
        {
            _topicAppService = topicAppService;
        }

        // GET: topics
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Topic>> Get()
        {
            return await _topicAppService.GetAllAsync();
        }

        // GET: topics/5
        [Route("{id:int}")]
        [HttpGet]
        public async Task<Topic> Get(int id)
        {
            return await _topicAppService.GetAsync(id);
        }

        // POST: topics
        [Route("")]
        [HttpPost]
        public void Post([FromBody]Topic value)
        {
            _topicAppService.Add(value);
        }

        // PUT: topics/5
        [Route("{id:int}")]
        [HttpPut]
        public void Put(int id, [FromBody]Topic value)
        {
        }

        // DELETE: topics/5
        [Route("{id:int}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _topicAppService.Remove(id);
        }
    }
}

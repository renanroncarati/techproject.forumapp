﻿using ForumApp.Application.Service.Interfaces;
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
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: users/5
        [Route("{id:int}")]
        [HttpGet]
        public async Task<User> Get(int id)
        {
            return await _userAppService.GetAsync(id);
        }

        // POST: users
        [Route("")]
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _userAppService.Add(value);
        }

        // PUT: users/5
        [Route("{id:int}")]
        [HttpPut]
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE: users/5
        [Route("{id:int}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _userAppService.Remove(id);
        }
    }
}

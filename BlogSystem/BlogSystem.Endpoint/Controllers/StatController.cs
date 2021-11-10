﻿using BlogSystem.Data;
using BlogSystem.Data.Models;
using BlogSystem.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogSystem.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IBlogLogic blogLogic;

        public StatController(IBlogLogic blogLogic)
        {
            this.blogLogic = blogLogic;
        }


        // GET: stat/GetLeastUsedCategory
        [HttpGet]
        public CategoryAndCount GetLeastUsedCategory()
        {
            return blogLogic.GetLeastUsedCategory();
        }

        // GET: stat/GetBlogsWithRudeComments
        [HttpGet]
        public IList<Blog> GetBlogsWithRudeComments()
        {
            return blogLogic.GetBlogsWithRudeComments();
        }

    }
}

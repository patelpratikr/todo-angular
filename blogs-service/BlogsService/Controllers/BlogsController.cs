using BlogsService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BlogsService.Controllers
{   
    public class BlogsController : Controller
    {
        // GET: Blogs
        public string GetAll()
        {
            var blogsEntities = new BlogsEntities();

            var blogs = blogsEntities.Blogs.ToList();

            return JsonConvert.SerializeObject(blogs);
        }                
    }
}
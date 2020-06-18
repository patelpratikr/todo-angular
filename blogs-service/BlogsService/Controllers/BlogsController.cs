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
        private IBlogRepository _blogRepository;

        public BlogsController(IBlogRepository repository)
        {
            _blogRepository = repository;
        }

        // GET: Blogs
        public string GetAll()
        {
            try
            {
                return JsonConvert.SerializeObject(_blogRepository.GetAll());
            }
            catch
            {
                return string.Empty;
            }
        }

        // GET: Blogs
        public bool Delete(int blogId)
        {
            try
            {
                return _blogRepository.Delete(blogId);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(Blog blog)
        {
            try
            {
                return _blogRepository.Add(blog);
            }
            catch
            {
                return false;
            }
        }

    }
}
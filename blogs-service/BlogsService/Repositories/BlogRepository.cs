using BlogsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsService.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public List<Blog> GetAll()
        {
            try
            {
                var blogsEntities = new BlogsEntities();

                var blogs = blogsEntities.Blogs.ToList();

                return blogs;
            }
            catch
            {
                return null;
            }
        }

        // GET: Blogs
        public bool Delete(int blogId)
        {
            try
            {
                var blogsEntities = new BlogsEntities();

                blogsEntities.Blogs.Remove(blogsEntities.Blogs.Where(a => a.ID == blogId).FirstOrDefault());

                blogsEntities.SaveChanges();

                return true;
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
                var blogEntities = new BlogsEntities();

                blogEntities.Blogs.Add(blog);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
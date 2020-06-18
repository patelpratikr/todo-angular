using BlogsService.Models;
using System.Collections.Generic;

namespace BlogsService
{
    public interface IBlogRepository
    {
        List<Blog> GetAll();

        bool Delete(int blogId);

        bool Add(Blog blog);
    }
}
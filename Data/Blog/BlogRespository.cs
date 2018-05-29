using System;
using System.Collections.Generic;
using Business.Blog;
using BlogEntity = Business.Blog.Blog;

namespace Data.Blog
{
    public class BlogRespository : IRepository<BlogEntity>
    {
        public bool Delete(BlogEntity blog)
        {
            throw new NotImplementedException();
        }

        public BlogEntity Get(int id) {
            BlogEntity blog = new BlogEntity();
            blog.Id = id;
            blog.Title = "Fit after Fourty-Five";
            IList<BlogEntry> entries = new List<BlogEntry>();
            for (var i = 0; i < 10; i++) {
                BlogEntry entry = new BlogEntry();
                entry.Id = i;
                entry.Title = "Post " + i.ToString();
                entry.Content = "There is some blog content here";
                entries.Add(entry);
            }
            blog.Entries = entries;
            return blog;
        }

        public bool Insert(BlogEntity blog)
        {
            throw new NotImplementedException();
        }

        public bool Update(BlogEntity blog)
        {
            throw new NotImplementedException();
        }
    }
}

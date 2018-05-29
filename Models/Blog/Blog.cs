using System.Collections.Generic;

namespace Business.Blog
{
    public class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IList<BlogEntry> Entries { get; set; }
    }
}

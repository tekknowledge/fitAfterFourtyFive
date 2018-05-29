using System.Collections.Generic;


namespace WebApplication1.Models.ViewModel
{
    public class Blog {

        public string Title { get; set; }

        public IList<BlogEntry> Entries { get; set; }
    }
}
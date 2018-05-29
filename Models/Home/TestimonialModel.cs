using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Home
{
    public class TestimonialModel
    {
        public TestimonialModel() {
            Testimonials = new TestimonialCollection();
        }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public TestimonialCollection Testimonials { get; set; }

        public string Content { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Home;

namespace Business.Home
{
    public class TestimonialCollection {
        private readonly List<Testimonial> _testimonials;

        public TestimonialCollection() {
            this._testimonials = new List<Testimonial>();
        }

        public IList<Testimonial> Testimonials
        {
            get { return _testimonials; }
        }

        public void AddTestimonial(Testimonial testimonial) {
            _testimonials.Add(testimonial);
        }
    }
}

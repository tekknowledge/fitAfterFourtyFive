using System.Collections.Generic;

namespace WebApplication1.Models.ViewModel
{
    public class Homepage
    {

        public string Title { get; set; }

        public WelcomeSection Welcome { get; set; }

        public MeetMeSection MeetMe { get; set; }

        public MyServicesSection MyServices { get; set; }

        public MyTestimonialsSection Testimonials { get; set; }
    }
    
    public interface IHomePageTemplate {
        
        string Heading { get; set; }

        string Blurb { get; set; }

        string ImageUrl { get; set; }
    }

    public class WelcomeSection : IHomePageTemplate {
        public string Heading { get; set; }

        public string Blurb { get; set; }

        public string ImageUrl { get; set; }
    }

    public class MeetMeSection : IHomePageTemplate {
        public string Heading { get; set; }

        public string Blurb { get; set; }

        public string ImageUrl { get; set; }
    }

    public class MyServicesSection : IHomePageTemplate {
        public string Heading { get; set; }
        public string Blurb { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<IHomePageTemplate> Services { get; set; }
    }

    public class Service : IHomePageTemplate {
        public string Heading { get; set; }

        public string SubHeading { get; set;}
        public string Blurb { get; set; }
        public string ImageUrl { get; set; }
    }

    public class MyTestimonialsSection : IHomePageTemplate {
        public string Heading { get; set; }
        public string Blurb { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<IHomePageTemplate> Testimonials { get; set; }
    }

    public class Testimonal : IHomePageTemplate {
        public string Heading { get; set; }
        public string Blurb { get; set; }
        public string ImageUrl { get; set; }
    }
}
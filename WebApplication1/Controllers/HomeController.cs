using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using WebApplication1.Models.ViewModel;
using Business.Blog;
using Business.Home;
using Data.Home;
using BusinessEntity = Business.Blog;
using Utility.DataAccess;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            Homepage homepage = new Homepage();
            homepage.Title = "Fit After Fourty-Five";

            DatabaseConnectionFactory factory = DatabaseConnectionFactory.Instance;
            IDbConnection connection = factory.GetConnection("DefaultConnection");

            IRepository<WelcomeModel> repo = new WelcomeRepository(connection);
            WelcomeModel model = repo.Get(1);

            homepage.Welcome = new WelcomeSection();
            homepage.Welcome.Heading = model.Title;
            homepage.Welcome.Blurb = model.Content;
            homepage.Welcome.ImageUrl = model.ImageUrl;

            IRepository<MeetMeModel> repoMeetMe = new MeetMeRepository(connection);
            MeetMeModel meetMe = repoMeetMe.Get(1);

            homepage.MeetMe = new MeetMeSection();
            homepage.MeetMe.Heading = meetMe.Title;
            homepage.MeetMe.ImageUrl = meetMe.ImageUrl;
            homepage.MeetMe.Blurb = meetMe.Content;

            IRepository<ServicesModel> repoServices = new MyServicesRepository(connection);
            ServicesModel services = repoServices.Get(1);

            homepage.MyServices = new MyServicesSection();
            homepage.MyServices.Heading = services.Title;
            homepage.MyServices.ImageUrl = services.ImageUrl;
            homepage.MyServices.Blurb = services.Content;
            List<IHomePageTemplate> listOfServices = new List<IHomePageTemplate>();
            foreach (var svc in services.Services.Services) {
                listOfServices.Add(new Models.ViewModel.Service() {
                    Heading = svc.Title,
                    Blurb = svc.Content,
                    ImageUrl = svc.ImageUrl,
                    SubHeading = svc.SubTitle
                });
            }
            homepage.MyServices.Services = listOfServices;



            
            TestimonialRepository tRepo = new TestimonialRepository(connection);
            TestimonialModel testimonials = tRepo.Get(1);

            homepage.Testimonials = new MyTestimonialsSection();
            homepage.Testimonials.Testimonials = new List<IHomePageTemplate>();
            homepage.Testimonials.Heading = "Client Testimonials";
            homepage.Testimonials.Testimonials = new List<IHomePageTemplate>();

            List<IHomePageTemplate> listOfTestimonials = new List<IHomePageTemplate>();

            foreach (var t in testimonials.Testimonials.Testimonials) {
                listOfTestimonials.Add(new Models.ViewModel.Testimonal() {
                    Heading = t.Title,
                    Blurb = t.Content + "<br/><br/>~" + t.Name,
                    ImageUrl = t.ImageUrl
                });
            }
            homepage.Testimonials.Testimonials = listOfTestimonials;

            return View(homepage);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();

            Dictionary<string, Type> mappings = new Dictionary<string, Type>();
            mappings.Add("varchar", typeof(string));
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";
            IRepository<BusinessEntity.Blog> blogRepo = new Data.Blog.BlogRespository();
            BusinessEntity.Blog blog = blogRepo.Get(1);

            Models.ViewModel.Blog vmBlog = new Models.ViewModel.Blog();

            vmBlog.Entries = new List<Models.ViewModel.BlogEntry>();
            vmBlog.Title = blog.Title;
            foreach (var entry in blog.Entries) {
                vmBlog.Entries.Add(new Models.ViewModel.BlogEntry() {Content = entry.Content, Title = entry.Title});
            }


            return View("~/Views/Blog/Blog.cshtml", vmBlog);
        }
    }
}
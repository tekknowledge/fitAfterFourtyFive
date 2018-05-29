using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Home;

namespace Business.Home
{
    public class ServicesModel {
        private readonly ServicesCollection _servicesCollection;

        public ServicesModel() {
            _servicesCollection = new ServicesCollection();
        }
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }

        public ServicesCollection Services
        {
            get { return _servicesCollection; }
        }
    }
}

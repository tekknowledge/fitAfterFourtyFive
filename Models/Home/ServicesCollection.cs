using System.Collections.Generic;


namespace Models.Home
{
    public class ServicesCollection {
        private readonly IList<Service> _services;

        public ServicesCollection() {
            _services = new List<Service>();
        }

        public IList<Service> Services
        {
            get { return _services; }
        }

        public void AddService(Service service) {
            _services.Add(service);
        }
    }
}

using System;
using System.Data;
using Business.Home;
using Models.Home;
using Utility.DataAccess;
using Utility.Extension;

namespace Data.Home
{
    public class MyServicesRepository : SqlRepository<ServicesModel> {
        public override ServicesModel Get(int id) {
            ServicesModel model = new ServicesModel();

            ISqlWorker worker = new SqlWorker(connection);
            worker.SetupCommand(@"
                    SELECT id, heading, subHeading, blurb, backgroundImageUrl
                    FROM MyServicesSection
                    WHERE id = @id
                ", CommandType.Text);
            worker.AddInputParameter("@id", id);

            using (var rdr = worker.GetDataReader())
            {
                if (rdr.Read())
                {
                    model.Title = rdr["heading"].SafeToString();
                    model.SubTitle = rdr["subHeading"].SafeToString();
                    model.ImageUrl = rdr["backgroundImageUrl"].SafeToString();
                    model.Content = rdr["blurb"].SafeToString();
                    model.Id = rdr["id"].SafeToInt();
                }
            }

            worker.SetupCommand(@"
                    SELECT id, heading, subHeading, blurb, backgroundImageUrl
                    FROM ServiceOffered
                    WHERE idMyServices = @collectionId
                ", CommandType.Text);
            worker.AddInputParameter("@collectionId", model.Id);

            using (var rdr = worker.GetDataReader())
            {
                while (rdr.Read()) {
                    Service svc = new Service();
                    svc.Title = rdr["heading"].SafeToString();
                    svc.SubTitle = rdr["subHeading"].SafeToString();
                    svc.ImageUrl = rdr["backgroundImageUrl"].SafeToString();
                    svc.Content = rdr["blurb"].SafeToString();
                    svc.Id = rdr["id"].SafeToInt();
                    model.Services.AddService(svc);
                }
            }

            return model;
        }

        public bool Insert(ServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(ServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ServicesModel entity)
        {
            throw new NotImplementedException();
        }

        public MyServicesRepository(IDbConnection connection) : base(connection) { }
    
    }
}

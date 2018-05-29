using System;
using System.Data;
using Business.Home;
using Utility.DataAccess;
using Utility.Extension;

namespace Data.Home
{
    public class WelcomeRepository : SqlRepository<WelcomeModel> {

        public WelcomeRepository(IDbConnection connection) : base(connection) { }

        public override WelcomeModel Get(int id) {
            ISqlWorker worker = new SqlWorker(connection);
            worker.SetupCommand(@"
                SELECT id, heading, subHeading, blurb, backgroundImageUrl
                FROM welcomeSection
                WHERE id = @id
            ", CommandType.Text);
            worker.AddInputParameter("@id", id);

            WelcomeModel model = new WelcomeModel();

            using (var rdr = worker.GetDataReader()) {
                if (rdr.Read()) {
                    model.Title = rdr["heading"].SafeToString();
                    model.SubTitle = rdr["subHeading"].SafeToString();
                    model.ImageUrl = rdr["backgroundImageUrl"].SafeToString();
                    model.Content = rdr["blurb"].SafeToString();
                }
            }

            //    WelcomeModel model = new WelcomeModel();
            //model.Title = "Get Fit. <br/> Have Fun.";
            //model.SubTitle = "Train Like a Champion";
            //model.Content = "This is your Welcome section paragraph. As the first text readers encounter, this copy should clearly convey what your site is all about. Grab their attention with captivating and inviting copy, and add an image or video for extra engagement.";
            //model.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK1WQO38rPdcx8OgEKLaxarm0QnMwqKvwNBKpIR4z3VeeoU1iJ";
            return model;
        }

        public bool Insert(WelcomeModel entity) {
            throw new NotImplementedException();
        }

        public bool Update(WelcomeModel entity) {
            throw new NotImplementedException();
        }

        public bool Delete(WelcomeModel entity) {
            throw new NotImplementedException();
        }
    }
}

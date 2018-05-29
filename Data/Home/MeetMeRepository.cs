using System;
using System.Data;
using Business.Home;
using Utility.DataAccess;
using Utility.Extension;

namespace Data.Home
{
    public class MeetMeRepository : SqlRepository<MeetMeModel>
    {
        public override MeetMeModel Get(int id) {
            MeetMeModel model = new MeetMeModel();

            ISqlWorker worker = new SqlWorker(connection);
            worker.SetupCommand(@"
                SELECT id, heading, subHeading, blurb, backgroundImageUrl
                FROM meetmeSection
                WHERE id = @id
            ", CommandType.Text);
            worker.AddInputParameter("@id", id);

            using (var rdr = worker.GetDataReader()) {
                if (rdr.Read()) {
                    model.Title = rdr["heading"].SafeToString();
                    model.SubTitle = rdr["subHeading"].SafeToString();
                    model.ImageUrl = rdr["backgroundImageUrl"].SafeToString();
                    model.Content = rdr["blurb"].SafeToString();
                    model.Id = rdr["id"].SafeToInt();
                }
            }

            return model;
        }

        public bool Insert(MeetMeModel entity) {
            throw new NotImplementedException();
        }

        public bool Update(MeetMeModel entity) {
            throw new NotImplementedException();
        }

        public bool Delete(MeetMeModel entity) {
            throw new NotImplementedException();
        }

        public MeetMeRepository(IDbConnection connection) : base(connection) {}
    }
}

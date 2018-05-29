using System;
using System.Collections.Generic;
using System.Data;
using Business.Home;
using Models.Home;
using Utility.DataAccess;
using Utility.Extension;

namespace Data.Home
{
    public class TestimonialRepository : SqlRepository<TestimonialModel>
    {
        public IList<TestimonialModel> GetCollection() {
            TestimonialModel m1 = new TestimonialModel();
            m1.Name = "Riley Jones";
            m1.Content = "Jane's helped me tone up and lose weight, but more importantly, she's motivated me to make healthier lifestyle decisions day to day.";
            m1.ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIAHkAbgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAAAAgMFBgQBB//EADYQAAEEAQIDBAYJBQAAAAAAAAEAAgMRBAUSITFBBlFhsRMUInFykSMkMjRCUoGh0TNTYpLB/8QAGAEAAwEBAAAAAAAAAAAAAAAAAAIDAQT/xAAdEQEBAQEAAgMBAAAAAAAAAAAAAQIREjEDIVEi/9oADAMBAAIRAxEAPwDXbQjaE9IpdDnJtCNoT0ikAm0JXlkbdz3Bo7yaXNqOZ6CPbEWlzrFg8WqleXPcXPcXE9SU0z0tq/8AWsb+/H/sF6yeCR21krHOPQOWepFJvBnk021G0KgiysiIjZK7h0JsK4wsxmSKNNk6t7/clubDSp9oRtCekUlaTaEbQnpFIBqRSkQhiOlXatkyRFsUTtpItxHNWqz2eS7MlN2N1BNmfbK5CDdryipKRSqRHRRRUlIpAR0UzdzXBzTThyITUikBf4cvrGMyQ1u5OrvU1Kv0R7qlj/CKcFaKN+qpKjpFKRCwGrwRXgpKRSGoJyWQSOaOIaaWaPE2eJ8VqyARRHArN5UIiyJIxyaeHuT4Lpz0rvQezsurRmczNigDtt1bifAKn2rR6Lr8Wk6QYWxmXIdIXBt0AKHElbvy5/LM879rqHshpUbakE0p73SV5Ukyux2nSMPq7pYX9Du3D9Qf5Wfn7T6tK+25DYh+VjBQ+drS9k9WydThnbl058RFSAVuBv8AhR1PkzO9VlxbzjFarpk+l5RgyADYtjxycO9cVLddu42O0+CQ/bbNQPgQb8gsRtVsa8s9T3OXjp0n763xBV7SqdGi3ZDn9Gtr9Srqku/YyjrwRXgpKRSUxqRSakUgFpZ7OkbPkukYCBy4rR0s3ktrIlHc8+afBdIKRSakUqETYGDPn5LcfGZbjzPRo7yvoel6fBpOF6JjhQ9qSR3Cz3rk7J4TMbSo5aHpJ/bcfDoPkqfthqcr8l2nxEtiZRkr8ZIuvcufVvya8YvmTGfJw9ptXGp5LWQk+rw3tP5j3qlpNSKV5OTiNvb1b6MxoxnEcy/irClzaUzbhMPeSf3XXSlfZ56LSKTUiljToT0ikAiqdUw3+kdPE22kW+uiuaXjmBzXNPIggrZeVlnWUpegJ3NLXFp5g0vKVk2u0ztFp+Lp2PBK6QPjjDXUy+Kzes5EeZqc+RBZjeRRIroB/wAWw0fTMGXS8V8mJC57owS4sFkrK69CyHV8mOJgYxpFNbwA4BR+Px8rxXffGdVlFFJ6XfpEG/IMhHsxj91W3icWeNGIseNg6NCkT0ilE5EJ6RSGnpFJqRSGFpFJqSyvZEwvkcGtHMlAZvKH1qb4z5qKlNOQ+eRzfsucSPmk2q8Td0Gt6jjwshiyNsbBTRsaaHyXFkzy5U7553bpH/aNAX8l5tRtWTMje0lK60YfVHcPxnyCqNquNHkiEAi3D0m4ktJ8lm/Tc+3dSKT0vKUjFpFJqRSAkpeGgLJAA6leTvMUEkgFlrSaVBkZMuQfpXWByb0C2Z6LeLSbUseOw0mQ/wCI4fNVGTPJkSbnk10b0CSkUqTMhLelpFJqRSZhaRSakUgFpAFGxzTUikBaYOoM9HsyX04cnEcx4qxY5r27mODgeoNrNUnikfE7dG4tPgUlx+GmmkpFLi03LkyS9kgb7IvcBVrvpTs4aI81v1Ob4Cs7RWkzfuk3wFZ1UwXRaKKKZCcpaKKKZCAWiiimQgFooopkIBaKKKZCAsNEH00vwjzVvSqdE/rS/APNW6lr2pPT/9k=";

            TestimonialModel m2 = new TestimonialModel();
            m2.Name = "Riley Jones";
            m2.ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIAHkAbgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAAAAgMFBgQBB//EADYQAAEEAQIDBAYJBQAAAAAAAAEAAgMRBAUSITFBBlFhsRMUInFykSMkMjRCUoGh0TNTYpLB/8QAGAEAAwEBAAAAAAAAAAAAAAAAAAIDAQT/xAAdEQEBAQEAAgMBAAAAAAAAAAAAAQIREjEDIVEi/9oADAMBAAIRAxEAPwDXbQjaE9IpdDnJtCNoT0ikAm0JXlkbdz3Bo7yaXNqOZ6CPbEWlzrFg8WqleXPcXPcXE9SU0z0tq/8AWsb+/H/sF6yeCR21krHOPQOWepFJvBnk021G0KgiysiIjZK7h0JsK4wsxmSKNNk6t7/clubDSp9oRtCekUlaTaEbQnpFIBqRSkQhiOlXatkyRFsUTtpItxHNWqz2eS7MlN2N1BNmfbK5CDdryipKRSqRHRRRUlIpAR0UzdzXBzTThyITUikBf4cvrGMyQ1u5OrvU1Kv0R7qlj/CKcFaKN+qpKjpFKRCwGrwRXgpKRSGoJyWQSOaOIaaWaPE2eJ8VqyARRHArN5UIiyJIxyaeHuT4Lpz0rvQezsurRmczNigDtt1bifAKn2rR6Lr8Wk6QYWxmXIdIXBt0AKHElbvy5/LM879rqHshpUbakE0p73SV5Ukyux2nSMPq7pYX9Du3D9Qf5Wfn7T6tK+25DYh+VjBQ+drS9k9WydThnbl058RFSAVuBv8AhR1PkzO9VlxbzjFarpk+l5RgyADYtjxycO9cVLddu42O0+CQ/bbNQPgQb8gsRtVsa8s9T3OXjp0n763xBV7SqdGi3ZDn9Gtr9Srqku/YyjrwRXgpKRSUxqRSakUgFpZ7OkbPkukYCBy4rR0s3ktrIlHc8+afBdIKRSakUqETYGDPn5LcfGZbjzPRo7yvoel6fBpOF6JjhQ9qSR3Cz3rk7J4TMbSo5aHpJ/bcfDoPkqfthqcr8l2nxEtiZRkr8ZIuvcufVvya8YvmTGfJw9ptXGp5LWQk+rw3tP5j3qlpNSKV5OTiNvb1b6MxoxnEcy/irClzaUzbhMPeSf3XXSlfZ56LSKTUiljToT0ikAiqdUw3+kdPE22kW+uiuaXjmBzXNPIggrZeVlnWUpegJ3NLXFp5g0vKVk2u0ztFp+Lp2PBK6QPjjDXUy+Kzes5EeZqc+RBZjeRRIroB/wAWw0fTMGXS8V8mJC57owS4sFkrK69CyHV8mOJgYxpFNbwA4BR+Px8rxXffGdVlFFJ6XfpEG/IMhHsxj91W3icWeNGIseNg6NCkT0ilE5EJ6RSGnpFJqRSGFpFJqSyvZEwvkcGtHMlAZvKH1qb4z5qKlNOQ+eRzfsucSPmk2q8Td0Gt6jjwshiyNsbBTRsaaHyXFkzy5U7553bpH/aNAX8l5tRtWTMje0lK60YfVHcPxnyCqNquNHkiEAi3D0m4ktJ8lm/Tc+3dSKT0vKUjFpFJqRSAkpeGgLJAA6leTvMUEkgFlrSaVBkZMuQfpXWByb0C2Z6LeLSbUseOw0mQ/wCI4fNVGTPJkSbnk10b0CSkUqTMhLelpFJqRSZhaRSakUgFpAFGxzTUikBaYOoM9HsyX04cnEcx4qxY5r27mODgeoNrNUnikfE7dG4tPgUlx+GmmkpFLi03LkyS9kgb7IvcBVrvpTs4aI81v1Ob4Cs7RWkzfuk3wFZ1UwXRaKKKZCcpaKKKZCAWiiimQgFooopkIBaKKKZCAsNEH00vwjzVvSqdE/rS/APNW6lr2pPT/9k=";
            m2.Content = "Jane’s workouts are awesome! I feel fitter and healthier than ever, and I’ve never looked better.";


            TestimonialModel m3 = new TestimonialModel();
            m3.Name = "Riley Jones";
            m3.ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIAHkAbgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAAAAgMFBgQBB//EADYQAAEEAQIDBAYJBQAAAAAAAAEAAgMRBAUSITFBBlFhsRMUInFykSMkMjRCUoGh0TNTYpLB/8QAGAEAAwEBAAAAAAAAAAAAAAAAAAIDAQT/xAAdEQEBAQEAAgMBAAAAAAAAAAAAAQIREjEDIVEi/9oADAMBAAIRAxEAPwDXbQjaE9IpdDnJtCNoT0ikAm0JXlkbdz3Bo7yaXNqOZ6CPbEWlzrFg8WqleXPcXPcXE9SU0z0tq/8AWsb+/H/sF6yeCR21krHOPQOWepFJvBnk021G0KgiysiIjZK7h0JsK4wsxmSKNNk6t7/clubDSp9oRtCekUlaTaEbQnpFIBqRSkQhiOlXatkyRFsUTtpItxHNWqz2eS7MlN2N1BNmfbK5CDdryipKRSqRHRRRUlIpAR0UzdzXBzTThyITUikBf4cvrGMyQ1u5OrvU1Kv0R7qlj/CKcFaKN+qpKjpFKRCwGrwRXgpKRSGoJyWQSOaOIaaWaPE2eJ8VqyARRHArN5UIiyJIxyaeHuT4Lpz0rvQezsurRmczNigDtt1bifAKn2rR6Lr8Wk6QYWxmXIdIXBt0AKHElbvy5/LM879rqHshpUbakE0p73SV5Ukyux2nSMPq7pYX9Du3D9Qf5Wfn7T6tK+25DYh+VjBQ+drS9k9WydThnbl058RFSAVuBv8AhR1PkzO9VlxbzjFarpk+l5RgyADYtjxycO9cVLddu42O0+CQ/bbNQPgQb8gsRtVsa8s9T3OXjp0n763xBV7SqdGi3ZDn9Gtr9Srqku/YyjrwRXgpKRSUxqRSakUgFpZ7OkbPkukYCBy4rR0s3ktrIlHc8+afBdIKRSakUqETYGDPn5LcfGZbjzPRo7yvoel6fBpOF6JjhQ9qSR3Cz3rk7J4TMbSo5aHpJ/bcfDoPkqfthqcr8l2nxEtiZRkr8ZIuvcufVvya8YvmTGfJw9ptXGp5LWQk+rw3tP5j3qlpNSKV5OTiNvb1b6MxoxnEcy/irClzaUzbhMPeSf3XXSlfZ56LSKTUiljToT0ikAiqdUw3+kdPE22kW+uiuaXjmBzXNPIggrZeVlnWUpegJ3NLXFp5g0vKVk2u0ztFp+Lp2PBK6QPjjDXUy+Kzes5EeZqc+RBZjeRRIroB/wAWw0fTMGXS8V8mJC57owS4sFkrK69CyHV8mOJgYxpFNbwA4BR+Px8rxXffGdVlFFJ6XfpEG/IMhHsxj91W3icWeNGIseNg6NCkT0ilE5EJ6RSGnpFJqRSGFpFJqSyvZEwvkcGtHMlAZvKH1qb4z5qKlNOQ+eRzfsucSPmk2q8Td0Gt6jjwshiyNsbBTRsaaHyXFkzy5U7553bpH/aNAX8l5tRtWTMje0lK60YfVHcPxnyCqNquNHkiEAi3D0m4ktJ8lm/Tc+3dSKT0vKUjFpFJqRSAkpeGgLJAA6leTvMUEkgFlrSaVBkZMuQfpXWByb0C2Z6LeLSbUseOw0mQ/wCI4fNVGTPJkSbnk10b0CSkUqTMhLelpFJqRSZhaRSakUgFpAFGxzTUikBaYOoM9HsyX04cnEcx4qxY5r27mODgeoNrNUnikfE7dG4tPgUlx+GmmkpFLi03LkyS9kgb7IvcBVrvpTs4aI81v1Ob4Cs7RWkzfuk3wFZ1UwXRaKKKZCcpaKKKZCAWiiimQgFooopkIBaKKKZCAsNEH00vwjzVvSqdE/rS/APNW6lr2pPT/9k=";
            m3.Content = "Since I started training with Jane, she’s helped me meet - no, exceed - my personal fitness goals.";

            List<TestimonialModel> collection = new List<TestimonialModel>() {m1, m2, m3};
            return collection;

        }
        public TestimonialModel Get(int id) {
            TestimonialModel model = new TestimonialModel();

            ISqlWorker worker = new SqlWorker(connection);
            worker.SetupCommand(@"
                    SELECT id, heading, subHeading, blurb, backgroundImageUrl
                    FROM MyTestimonialsSection
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
                    SELECT id, heading, subHeading, blurb, backgroundImageUrl, name
                    FROM clientTestimonials
                    WHERE idMyTestimonials = @collectionId
                ", CommandType.Text);
            worker.AddInputParameter("@collectionId", model.Id);

            using (var rdr = worker.GetDataReader())
            {
                while (rdr.Read())
                {
                    Testimonial t = new Testimonial();
                    t.Title = rdr["heading"].SafeToString();
                    t.SubTitle = rdr["subHeading"].SafeToString();
                    t.ImageUrl = rdr["backgroundImageUrl"].SafeToString();
                    t.Content = rdr["blurb"].SafeToString();
                    t.Id = rdr["id"].SafeToInt();
                    t.Name = rdr["name"].SafeToString();
                    model.Testimonials.AddTestimonial(t);
                }
            }

            return model;
        }

        public bool Insert(TestimonialModel entity) {
            throw new NotImplementedException();
        }

        public bool Update(TestimonialModel entity) {
            throw new NotImplementedException();
        }

        public bool Delete(TestimonialModel entity) {
            throw new NotImplementedException();
        }

        public TestimonialRepository(IDbConnection connection) : base(connection) {}
    }
}

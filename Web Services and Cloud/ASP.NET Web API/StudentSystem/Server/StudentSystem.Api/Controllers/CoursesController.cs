
namespace StudentSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using StudentSystem.Models;

    public class CoursesController : ApiController
    {
        private StudentSystemDbContext db;

        public CoursesController()
        {
            this.db = new StudentSystemDbContext();
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.db
                .Courses
                .ToList());
        }

        public IHttpActionResult Post([FromBody] CourseModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var course = new Course()
                {
                    Name = model.Name,
                    Description = model.Description
                };

                this.db.Courses.Add(course);
                this.db.SaveChanges();

                return this.Created(this.Url.ToString(), course);
            }
        }

        public IHttpActionResult Put([FromBody] CourseModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var course = this.db
                    .Courses
                    .Where(x => x.Name == model.Name)
                    .FirstOrDefault();

                if (course == null)
                {
                    return this.NotFound();
                }
                else
                {
                    course.Description = model.Description;

                    this.db.SaveChanges();
                    return this.Ok(course);
                }
            }
        }

        public IHttpActionResult Delete([FromBody] string guid)
        {
            var course = this.db
                .Courses
                .Where(x => x.Id.ToString() == guid)
                .FirstOrDefault();

            if (course == null)
            {
                return this.NotFound();
            }
            else
            {
                this.db.Courses.Remove(course);
                return this.Ok(course);
            }
        }
    }
}
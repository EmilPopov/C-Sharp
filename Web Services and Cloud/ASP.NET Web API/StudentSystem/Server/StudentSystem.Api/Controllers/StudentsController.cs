namespace StudentSystem.Api.Controllers
{
    using Models;
    using Data;
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Linq;
    using Models.Student;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private StudentSystemDbContext db;

        public StudentsController()
        {
            this.db = new StudentSystemDbContext();
        }


        // GET api/students
        public IHttpActionResult Get()
        {
            var result = db
                .Students
                .ToList();

            return this.Ok(result);
                
        }

        // GET api/students/5
        public IHttpActionResult Get(int id)
        {
            var result = db
                .Students
                .Where(s => s.StudentIdentification == id);

            if (result.Count() == 0)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        // POST api/students
        public IHttpActionResult Post([FromBody] StudentModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var student = new Student()
                {             
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                this.db.Students.Add(student);
                this.db.SaveChanges();

                return this.Created(this.Url.ToString(), student);
            }
        }

        public IHttpActionResult Put(int id, [FromBody] StudentModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var student = this.db
                    .Students
                    .Where(x => x.StudentIdentification == id)
                    .FirstOrDefault();

                if (student == null)
                {
                    return this.NotFound();
                }
                else
                {
                    student.FirstName = model.FirstName;
                    student.LastName = model.LastName;

                    this.db.SaveChanges();
                    return this.Ok(student);
                }
            }
        }

        public IHttpActionResult Delete(int id)
        {
            var student = this.db
                .Students
                .Where(x => x.StudentIdentification == id)
                .FirstOrDefault();

            if (student == null)
            {
                return this.NotFound();
            }
            else
            {
                this.db.Students.Remove(student);

                return this.Ok(student);
            }
        }
    }
}

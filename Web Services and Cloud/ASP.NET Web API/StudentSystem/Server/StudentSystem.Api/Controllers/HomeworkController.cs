namespace StudentSystem.Api.Controllers
{
    using Data;
    using System.Linq;
    using System.Web.Http;

    public class HomeworksController : ApiController
    {
        private StudentSystemDbContext db;

        public HomeworksController()
        {
            this.db = new StudentSystemDbContext();
        }

        public IHttpActionResult Get()
        {
            var result = db
                .Homeworks
                .ToList();

            return this.Ok(result);
        }
    }
}

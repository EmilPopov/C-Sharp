

namespace SourceControlSystem.Api.Controllers
{
    using Models.Projects;
    using Common.Constants;
    using System.Linq;
    using System.Web.Http;
    using SourceControl.Data.Services;
    using System.Web.Http.Cors;
    using AutoMapper.QueryableExtensions;
    using AutoMapper;
    using SourceControlSystem.Models;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;
 

        public ProjectsController(IProjectsService projects)
        {
            this.projects = projects;
    
        }

        [EnableCors("*","*","*")]
        public IHttpActionResult Get()
        {
            Mapper.CreateMap<SoftwareProject, SoftwareProjectsDetailsResponseModels>()
                .ForMember(s => s.TotalUsers, opts => opts.MapFrom(s => s.Users.Count()));



            var result = this.projects
                .All(page : 1)
                .ProjectTo<SoftwareProjectsDetailsResponseModels>()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.BadRequest("Project can't be null");
            }

            var result = this.projects
                .All()
                .Where(pr => 
                       pr.Name == id 
                       && (!pr.Private 
                           || (pr.Private && pr.Users.Any(c => c.UserName == this.User.Identity.Name))))
                .ProjectTo<SoftwareProjectsDetailsResponseModels>()
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = projects.Add(
                model.Name, 
                model.Discription, 
                this.User.Identity.Name,
                model.Private);

            return this.Ok(createdProjectId);
        }


        [Route("api/projects/all")]
        public IHttpActionResult Get(int page,int pageSize = GlobalConstants.DefaultPageSize)
        {
           var result = projects
                .All(page: 1)
                .ProjectTo<SoftwareProjectsDetailsResponseModels>()
                .ToList();

            return this.Ok(result);
        }
    }
}

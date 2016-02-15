namespace SourceControl.Data.Services
{
    using System;
    using System.Linq;
    using SourceControlSystem.Models;
    using SourceControlSystem.Data;

    public class ProjectsService : IProjectsService
    {
        private readonly IRepository<SoftwareProject> projects;
        private readonly IRepository<User> users;


        public ProjectsService(IRepository<SoftwareProject> projects, IRepository<User> users)
        {
            var db = new SourceControlSystemDbContext();
            this.projects = new EfGenericRepository<SoftwareProject>(db);
            this.users = new EfGenericRepository<User>(db);

        }

        public int Add(string name, string description, string creator, bool isPrivate = false)
        {
            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == creator);


            var newProject = new SoftwareProject()
            {
                Name = name,
                Description = description,
                CreatedOn = DateTime.Now,
                Private = isPrivate
            };

            newProject.Users.Add(currentUser);

            this.projects.Add(newProject);
            this.projects.SaveChanges();

            return newProject.Id;
        }

        public IQueryable<SoftwareProject> All(int page = 1, int pageSize = 10)
        {
            return this.projects
                             .All()
                             .OrderByDescending(pr => pr.CreatedOn)
                             .Skip((page - 1) * pageSize)
                             .Take(pageSize);
        }
    }
}

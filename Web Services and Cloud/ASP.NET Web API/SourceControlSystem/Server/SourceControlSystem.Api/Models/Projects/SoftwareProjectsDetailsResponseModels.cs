
namespace SourceControlSystem.Api.Models.Projects
{
    using SourceControlSystem.Models;
    using System;
    using System.Linq.Expressions;
    using System.Linq;

    public class SoftwareProjectsDetailsResponseModels
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }

    }
}
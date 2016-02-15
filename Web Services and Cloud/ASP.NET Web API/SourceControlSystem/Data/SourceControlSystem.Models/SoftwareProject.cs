namespace SourceControlSystem.Models
{
    using Common.Constants;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SoftwareProject
    {
        private ICollection<User> users;

        private ICollection<Commit> commits;

        public SoftwareProject()
        {
            this.users = new HashSet<User>();
            this.commits = new HashSet<Commit>();
        }

        public int Id { get; set; }

        public bool Private { get; set; }

        [MaxLength(ValidationConstants.MaxProjectDiscription)]
        public string Description { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxProjectName)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public virtual ICollection<Commit> Commits
        {
            get { return this.commits; }
            set { this.commits = value; }
        }
    }
}

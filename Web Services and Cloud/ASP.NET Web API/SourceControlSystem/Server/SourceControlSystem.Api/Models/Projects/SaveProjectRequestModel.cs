namespace SourceControlSystem.Api.Models.Projects
{
    using Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class SaveProjectRequestModel
    {
        [Required]
        [MaxLength(ValidationConstants.MaxProjectName)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxProjectDiscription)]
        public string Discription { get; set; }

        public bool Private { get; set; }
    }
}
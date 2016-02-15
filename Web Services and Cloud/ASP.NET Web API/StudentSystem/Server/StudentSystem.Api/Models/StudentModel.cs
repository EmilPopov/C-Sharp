
namespace StudentSystem.Api.Models.Student
{
    using System.ComponentModel.DataAnnotations;

    public class StudentModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
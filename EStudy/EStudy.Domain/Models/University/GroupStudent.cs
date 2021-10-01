using System.ComponentModel.DataAnnotations;
namespace EStudy.Domain.Models.University
{
    public class GroupStudent : BaseModel<int>
    {
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }
        [Required]
        public GroupStudentType StudentType { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
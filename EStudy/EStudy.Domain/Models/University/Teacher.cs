using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Teacher : BaseModel<int>
    {
        [Required, StringLength(250)]
        public string FullName { get; set; }
        [Required, StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }
        [Required, StringLength(50, MinimumLength = 1)]
        public string MiddleName { get; set; }
        [Required, StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Avatar { get; set; }
        public List<ChairTeacher> ChairTeachers { get; set; }
    }
}
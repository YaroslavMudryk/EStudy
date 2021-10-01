using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Chair : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Name { get; set; }
        [Required, StringLength(150, MinimumLength = 5)]
        public string EnName { get; set; }
        [StringLength(250)]
        public string Logo { get; set; }
        public int? AboutPayloadId { get; set; }
        public int? ManagementPayloadId { get; set; }
        public int InstituteId { get; set; }
        public Institute Institute { get; set; }
        public List<Specialty> Specialties { get; set; }
        public List<ChairTeacher> ChairTeachers { get; set; }
    }
}
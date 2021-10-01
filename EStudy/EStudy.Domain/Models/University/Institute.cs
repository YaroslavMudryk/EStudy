using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Institute : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Name { get; set; }
        [StringLength(5000)]
        public string About { get; set; }
        [StringLength(2500)]
        public string ManagementOfTheInstitutePayload { get; set; }
        [StringLength(2500)]
        public string AboutPayload { get; set; }
    }
}
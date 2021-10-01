using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Institute : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Name { get; set; }
        [Required, StringLength(150, MinimumLength = 5)]
        public string EnName { get; set; }
        [StringLength(5000)]
        public string About { get; set; }
        [StringLength(2500)]
        public string ManagementPayload { get; set; }
        [StringLength(2500)]
        public string AboutPayload { get; set; }
        public int UnivercityId { get; set; }
        public University University { get; set; }
        public List<Chair> Chairs { get; set; }
    }
}
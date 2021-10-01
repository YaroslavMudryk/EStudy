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
        [StringLength(20000)]
        public string AboutPayload { get; set; }
        [StringLength(2500)]
        public string ManagementPayload { get; set; }
    }
}
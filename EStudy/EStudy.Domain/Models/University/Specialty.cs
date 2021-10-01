using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Specialty : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Name { get; set; }
        [Required, StringLength(150, MinimumLength = 5)]
        public string EnName { get; set; }
        [StringLength(1000, MinimumLength = 5)]
        public string Info { get; set; }
        [StringLength(1000, MinimumLength = 5)]
        public string PdfDocument { get; set; }
        public int ChairId { get; set; }
        public Chair Chair { get; set; }
        public List<Group> Groups { get; set; }
    }
}
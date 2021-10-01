using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class University : BaseModel<int>
    {
        [Required, StringLength(300, MinimumLength = 5)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Logo { get; set; }
        public string CodeEDEBO { get; set; }
        [Required, StringLength(30, MinimumLength = 2)]
        public string ShortName { get; set; }
        [Required]
        public string EnName { get; set; }
        [StringLength(12)]
        public string IdentityCode { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(100)]
        public string Owner { get; set; }
        [StringLength(250)]
        public string DependsOn { get; set; }
        [StringLength(250)]
        public string Rector { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(15, MinimumLength = 7)]
        public string Phone { get; set; }
        [StringLength(100, MinimumLength = 5)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [StringLength(5000)]
        public string History { get; set; }
        [StringLength(15)]
        public string YearOfFoundation { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.Identity
{
    public class Role : BaseModel<int>
    {
        [Required, StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }
        [Required, StringLength(100, MinimumLength = 1)]
        public string SystemName { get; set; }
        [Required]
        public int LvlAccess { get; set; }
    }
}
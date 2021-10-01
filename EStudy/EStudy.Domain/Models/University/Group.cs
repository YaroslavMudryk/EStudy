using System.ComponentModel.DataAnnotations;

namespace EStudy.Domain.Models.University
{
    public class Group : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        public int Course { get; set; }
        [Required, StringLength(6)]
        public string CodeConnect { get; set; }
        [Required, StringLength(25, MinimumLength = 25)]
        public string InviteLink { get; set; }
        public string ManagmentPayload { get; set; }
    }
}
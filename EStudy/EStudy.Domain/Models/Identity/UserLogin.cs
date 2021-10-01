using System;
using System.ComponentModel.DataAnnotations;
namespace EStudy.Domain.Models.Identity
{
    public class UserLogin : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Login { get; set; }
        [StringLength(2500, MinimumLength = 8)]
        public string Password { get; set; }
        [Required, StringLength(50, MinimumLength = 1)]
        public string Type { get; set; } // email, google, facebook
        [Required]
        public bool IsConfirm { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        [StringLength(100, MinimumLength = 6)]
        public string TokenConfirm { get; set; }
        public int? ConfirmDataPayloadId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
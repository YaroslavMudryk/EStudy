using System.ComponentModel.DataAnnotations;
namespace EStudy.Domain.Models
{
    public class Payload : BaseModel<int>
    {
        public string Name { get; set; } //name of object
        [Required, StringLength(50000)]
        public string Date { get; set; }
        public PayloadType Type { get; set; }
    }
}
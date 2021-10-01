namespace EStudy.Domain.Models.University
{
    public class ChairTeacher : BaseModel<int>
    {
        public int ChairId { get; set; }
        public Chair Chair { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
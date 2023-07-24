namespace Domain.Model.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            UpdateAt = DateTime.Now;
        }

        public long Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
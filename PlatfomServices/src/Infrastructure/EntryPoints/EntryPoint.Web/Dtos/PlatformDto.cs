namespace EntryPoint.Web.Dtos
{
    public class PlatformDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
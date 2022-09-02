namespace OJT_Management.Models
{
    public class SubjectMatter
    {
        public int Id { get; set; }
        public string? Topic { get; set; }
        public string? Comments { get; set; }
        public string? AreaofOperation { get; set; }
        public DateTime DateTime { get { return DateTime.Now; } }
    }
}

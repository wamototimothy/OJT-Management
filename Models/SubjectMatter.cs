using System.ComponentModel;

namespace OJT_Management.Models
{
    public class SubjectMatter
    {
        public int Id { get; set; }
        public string? Topic { get; set; }
        public string? Comments { get; set; }
        [DisplayName("Area Of Operation")]
        public string? AreaofOperation { get; set; }
        [DisplayName("Subject Matter Date")]
        public DateTime SubjectMatterDate { get; set; }
    }
}

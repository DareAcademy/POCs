using System.ComponentModel.DataAnnotations.Schema;

namespace POCs.data
{
    public class Plan_Items
    {
        [ForeignKey("plan")]
        public int Plan_Id { get; set; }
        [ForeignKey("course")]
        public int Course_Id { get; set; }

        public Courses course { get; set; }
        public Plans plan { get; set; }
    }
}

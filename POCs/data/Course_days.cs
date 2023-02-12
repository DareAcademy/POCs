using System.ComponentModel.DataAnnotations.Schema;

namespace POCs.data
{
	public class Course_days
	{
		
		public int day { get; set; }

		[ForeignKey("sections")]
		public int Section_Id { get; set; }
		public Course_Sections sections { get; set; }
	}
}

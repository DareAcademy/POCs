using POCs.data;
using System.ComponentModel.DataAnnotations.Schema;

namespace POCs.DTO
{
	public class Course_days
	{
		public int day { get; set; }
		public int Section_Id { get; set; }
	}
}

namespace POCs.DTO
{
	public class Course_Sections
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }

		public List<Course_days> lidays { get; set; }
	}
}

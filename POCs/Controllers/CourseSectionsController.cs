using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POCs.data;
using POCs.DTO;

namespace POCs.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseSectionsController : ControllerBase
	{
		[HttpPost]
		[Route("Insert")]
		public void Insert(DTO.Course_Sections obj)
		{
			pocContext context = new pocContext();
			data.Course_Sections entity = new data.Course_Sections();
			entity.StartDate = obj.StartDate;
			entity.lidays = new List<data.Course_days>();
			foreach (DTO.Course_days item in obj.lidays)
			{
				data.Course_days dayInfo = new data.Course_days();
				dayInfo.day = item.day;
				entity.lidays.Add(dayInfo);
			}


			//entity.lidays = obj.lidays;
			context.course_Sections.Add(entity);
			context.SaveChanges();

		}
	}
}

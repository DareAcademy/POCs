using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POCs.data;

namespace POCs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        [Route("Load")]
        public void Load()
        {

            pocContext context = new pocContext();
            Plan_Items plan_Item = context.Plan_Items.Where(c => c.Course_Id == 1).FirstOrDefault();
           List<Courses> li= context.Courses.Where(c => c.liPlan_Items.Any(p => p.Plan_Id == plan_Item.Plan_Id)).ToList();

        }

    }
}

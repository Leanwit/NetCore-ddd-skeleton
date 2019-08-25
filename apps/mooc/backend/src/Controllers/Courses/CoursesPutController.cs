namespace backend.Controllers.Courses
{
    using Microsoft.AspNetCore.Mvc;
    using src.Mooc.Courses.Application.Create;

    [Route("[controller]")]
    public class CoursesPutController : Controller
    {
        private CourseCreator Creator;

        public CoursesPutController(CourseCreator creator)
        {
            Creator = creator;
        }


        [HttpPut]
        public IActionResult Invoke(string id, string name, string duration)
        {
            this.Creator.Invoke(new CreateCourseRequest(id, name, duration));

            return Ok();
        }
    }
}
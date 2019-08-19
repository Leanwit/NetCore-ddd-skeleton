namespace backend.Controllers.Courses
{
    using System.Net;
    using System.Net.Http;
    using Microsoft.AspNetCore.Mvc;
    using src.Mooc.Courses.Application.Create;

    public class CoursesPutController : ICoursesPutController
    {
        private CourseCreator Creator;

        public CoursesPutController(CourseCreator creator)
        {
            Creator = creator;
        }


        [HttpGet]
        public HttpResponseMessage Execute(string id, string name, string duration)
        {
            this.Creator.Execute(new CreateCourseRequest(id, name, duration));

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }

    public interface ICoursesPutController
    {
    }
}
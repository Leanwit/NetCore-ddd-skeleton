namespace backend.Controllers.CoursesCounter
{
    using Microsoft.AspNetCore.Mvc;
    using src.Mooc.CoursesCounter.Application.Find;

    [Route("[controller]")]
    public class CoursesCounterGetController : Controller
    {
        private CoursesCounterFinder Finder;

        public CoursesCounterGetController(CoursesCounterFinder finder)
        {
            Finder = finder;
        }

        [HttpGet]
        public IActionResult Invoke()
        {
            var response = this.Finder.Invoke();

            return Ok(response.Total);
        }
    }
}
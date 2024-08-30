using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class MovieController : Controller
    {
        //public string GetMovie(int id)
        //{
        //    return $"movie id ={id}";
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content= $"movie id ={id}";
        //    //result.ContentType = "object/pdf";
        //    result.StatusCode = 200 ;

        //    return result;
        //}



        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"movie id ={id}";
            ////result.ContentType = "object/pdf";
            //result.StatusCode = 200;

            //return Content($"movie id ={id}","text/html");
            //return RedirectToRoute(nameof(GetMovie));
            return Json(new { id });
        }


        [ActionName("Index")]
        [HttpGet]
        [AcceptVerbs("Get","Post")]
        public IActionResult redirectToMovcies()
        {
            return RedirectToAction(nameof(GetMovie), new{id=10});
        }
    }
}

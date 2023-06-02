using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramLib;
using WebApplicationCone.Models;

namespace WebApplicationCone.Controllers
{
    public class LibraryController : Controller
    {

        // GET: HomeControllerCone/Edit/5
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            var library = new LibraryModel(100, 10, 100);
            library.Volume = Library.TruncatedConeVolume(library.Height, library.SmallRadius, library.BigRadius);
            return View(library);
        }

        // POST: HomeControllerCone/Edit/5
        [HttpPost]
        [Route("Index")]
        public ActionResult Index(double Height, double SmallRadius, double BigRadius)
        {
            var library = new LibraryModel(Height, SmallRadius, BigRadius);
            library.Volume = Library.TruncatedConeVolume(library.Height, library.SmallRadius, library.BigRadius);
            return View(library);
        }

        // GET: HomeControllerCone/Delete/5
        
    }
}

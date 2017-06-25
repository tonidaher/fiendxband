using FiendXWebsite.Models;
using FiendXWebsite.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace FiendXWebsite.Controllers
{
    public class GigsController : Controller
    {
        private FiendXWebsiteContext _context;
        // GET: Gigs

            public GigsController()
        {
            _context = new FiendXWebsiteContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}
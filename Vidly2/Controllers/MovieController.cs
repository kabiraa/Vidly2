using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModel;

namespace Vidly2.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();      
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Movie/Index")]
        public ActionResult Index()
        {
            var movies = _context.Movie.Include(m => m.Genre).ToList();
            var viewModel = new GetMoviesViewModel {
                Movies = movies.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movie.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
    }
}
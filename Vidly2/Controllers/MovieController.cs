using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModel;

namespace Vidly2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "DDLJ" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" }
            };
            var viewModel = new RandomMovieViewModel{ Movie = movie, Customers = customers };
            return View(viewModel);
        }

        [Route("movie/Index")]
        public ActionResult Index()
        {
            var movies = GetMovies();
            var viewModel = new GetMoviesViewModel {
                Movies = movies.ToList()
            };
            return View(viewModel);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Name = "Tamasha", Id = 1},
                new Movie { Name = "Rockstar", Id = 2}
            };
        }

        public ActionResult MovieDetail(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            return Content(movie.Name);
        }
    }
}
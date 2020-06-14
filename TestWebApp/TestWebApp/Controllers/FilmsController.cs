using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TestWebApp.BusinessLogicLayer.Repositories.Interfaces;
using TestWebApp.BusinessLogicLayer.Services;
using TestWebApp.DBLayer.Models;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    [Authorize]
    public class FilmsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        
        public FilmsController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(int currentPage = 1)
        {            
            var filmsModel = GetFilmModelByParams(currentPage);

            return View(filmsModel);
        }

        public IActionResult PagingData(int currentPage = 1)
        {
            var filmsModel = GetFilmModelByParams(currentPage);

            return PartialView("_PagingData", filmsModel);            
        }

        private FilmsModel GetFilmModelByParams(int currentPage)
        {
            var user = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = user.Value;

            RepositoryService repositoryService = new RepositoryService(_unitOfWork);
            var filmsList = repositoryService.FilmService.GetRangeByParams(r => r, null, r => r.OrderBy(x => x.Name), r => r.Include(x => x.Poster).Include(x => x.Director), (currentPage - 1) * 10).ToList();
            var filmsCount = repositoryService.FilmService.GetCountByParams(r => r);

            filmsList.ForEach(r => {
                r.IsOwner = r.UserCreatorId.Equals(userId);
            });

            FilmsModel filmsModel = new FilmsModel()
            {
                FilmList = filmsList,
                Count = filmsCount,
                CurrentPage = currentPage
            };

            return filmsModel;
        }

        public IActionResult CreateFilm()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult CreateFilm(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                var userId = user.Value;

                RepositoryService repositoryService = new RepositoryService(_unitOfWork);

                try
                {
                    var film = new Film()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        ReleaseYear = model.ReleaseYear,
                        UserCreatorId = userId,
                        Director = new Director()
                        {
                            Name = model.Director
                        }
                    };

                    if (model.Poster != null)
                    {
                        byte[] imageData = null;

                        using (var binaryReader = new BinaryReader(model.Poster.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)model.Poster.Length);
                        }

                        film.Poster = new FileStore() { Content = Convert.ToBase64String(imageData), Type = "image/jpg" };
                    }

                    repositoryService.FilmService.Add(film);
                    _unitOfWork.Commit();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            return View();
        }

        public IActionResult UpdateFilm(int filmId)
        {
            var user = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = user.Value;

            RepositoryService repositoryService = new RepositoryService(_unitOfWork);
            var film = repositoryService.FilmService.GetRangeByParams(r => r, r => r.Id == filmId, null, r => r.Include(x => x.Director)).FirstOrDefault();

            CreateViewModel model = new CreateViewModel();

            if (film != null)
            {
                model.Name = film.Name;
                model.Description = film.Description;
                model.ReleaseYear = film.ReleaseYear ?? 0;
                model.Director = film.Director?.Name;  
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateFilm(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                var userId = user.Value;

                RepositoryService repositoryService = new RepositoryService(_unitOfWork);
                var film = repositoryService.FilmService.GetRangeByParams(r => r, r => r.Id == model.FilmId, null, r => r.Include(x => x.Director).Include(x => x.Poster)).FirstOrDefault();

                try
                {
                    film.Name = model.Name;
                    film.Description = model.Description;
                    film.ReleaseYear = model.ReleaseYear;
                    film.UserCreatorId = userId;


                    if (film.Director != null)
                    {
                        film.Director.Name = model.Director;
                    }
                    else
                    {
                        film.Director = new Director()
                        {
                            Name = model.Director
                        };
                    }
                    

                    if (model.Poster != null)
                    {
                        byte[] imageData = null;

                        using (var binaryReader = new BinaryReader(model.Poster.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)model.Poster.Length);
                        }

                        if (film.Poster != null)
                        {
                            film.Poster.Content = Convert.ToBase64String(imageData);
                        }
                        else
                        {
                            film.Poster = new FileStore() { Content = Convert.ToBase64String(imageData), Type = "image/jpg" };
                        }
                    }

                    repositoryService.FilmService.Update(film);
                    repositoryService.DirectorService.Update(film.Director);
                    repositoryService.FileStoreService.Update(film.Poster);
                    _unitOfWork.Commit();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            return View();
        }

        public IActionResult DeleteFilm(int filmId)
        {
            var user = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = user.Value;

            RepositoryService repositoryService = new RepositoryService(_unitOfWork);
            var film = repositoryService.FilmService.GetRangeByParams(r => r, r => r.Id == filmId, null, r => r.Include(x => x.Poster)).FirstOrDefault();

            if (film != null)
            {
                if (film.UserCreatorId.Equals(userId))
                {
                    try
                    {
                        repositoryService.FilmService.Delete(film.Id);
                        if (film.Poster != null)                        
                            repositoryService.FileStoreService.Delete(film.Poster.Id);                        

                        _unitOfWork.Commit();

                        return Ok();
                    }
                    catch (Exception ex) 
                    {
                        return StatusCode(500, ex.Message);
                    }
                }

                return Forbid();
            }

            return NotFound();
        }
    }
}
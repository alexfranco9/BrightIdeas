using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(user => user.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return RedirectToAction("dashideas");
            }
            return View("Index");
        }

        [HttpPost("checkLogin")]
        public IActionResult CheckLogin(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(user => user.Email == login.LoginEmail);

                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid login, email not register!");

                    ViewBag.AllUsers = _context.Users.ToList();
                    return View("Index");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid login, incorrect password!");

                    ViewBag.AllUsers = _context.Users.ToList();
                    return View("Index");
                }

                HttpContext.Session.SetInt32("userId", userInDb.UserId);

                return RedirectToAction("dashideas");

            }

            return View("Index");
        }

        [HttpGet("dashideas")]
        public IActionResult DashIdeas()
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);

            ViewBag.AllIdeas = _context.Ideas
                .Include(idea => idea.Creator)
                .Include(idea => idea.Likes)
                .OrderByDescending(idea => idea.Likes.Count)
                .ToList();
            
            ViewBag.AllUsers = _context.Users.ToList();

            return View();
        }

        [HttpPost("/idea/create")]
        public IActionResult CreateIdea(Idea newIdea)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            if(ModelState.IsValid)
            {
                newIdea.UserId = (int)loggedUserId;
                _context.Add(newIdea);
                _context.SaveChanges();
                
                return RedirectToAction("dashideas");
            }

            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);

            ViewBag.AllIdeas = _context.Ideas
                .Include(idea => idea.Creator)
                .Include(idea => idea.Likes)
                .ToList();
            
            ViewBag.AllUsers = _context.Users.ToList();

            return View("DashIdeas");   
        }

        [HttpGet("idea/{ideaId}/delete")]
        public IActionResult DeleteIdea(int ideaId)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            Idea deleteMe = _context.Ideas
                .FirstOrDefault(idea => idea.IdeaId == ideaId);

            _context.Ideas.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("dashideas");
        }

        [HttpGet("user/{id}")]
        public IActionResult SingleUser(int id)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.SingleUser = _context.Users
                .Include(user => user.CreatedIdeas)
                .ThenInclude(user => user.Likes)
                .FirstOrDefault(user => user.UserId == id);


            return View();
        }

        [HttpGet("ideas/{id}")]
        public IActionResult SingleIdea(int id)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            ViewBag.LoggedUser = _context.Users.FirstOrDefault(user => user.UserId == loggedUserId);

            ViewBag.SingleIdea = _context.Ideas
                .Include(idea => idea.Likes)
                .ThenInclude(user => user.User)
                .Include(idea => idea.Creator)
                .FirstOrDefault(idea => idea.IdeaId == id);

            return View();
        }

        [HttpGet("ideas/{ideaId}/like")]
        public IActionResult NewLike(int ideaId, int userId)
        {   
            int? loggedUserId = HttpContext.Session.GetInt32("userId");
            if(loggedUserId == null) return RedirectToAction("Index");

            Like checkForLike = _context.Likes
                .FirstOrDefault(lk => lk.UserId ==(int)loggedUserId && lk.IdeaId == ideaId);

            if(checkForLike == null)
            {
                Like newLike = new Like();
                newLike.UserId = (int)loggedUserId;
                newLike.IdeaId = ideaId;

                _context.Add(newLike);
                _context.SaveChanges();
            }
            else
            {
                return RedirectToAction("dashideas");
            }
            
            return RedirectToAction("dashideas");
        }

        [HttpGet("logout")]
        public IActionResult Logout ()
        {
            HttpContext.Session.Clear ();
            return View ("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

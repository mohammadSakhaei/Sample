using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class ProfileController : Controller
    {

        private readonly SampleContext _db;
        public ProfileController(SampleContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Profile profile)
        {
            if (!ModelState.IsValid)
                return View("Index");

            _db.Profile.Add(profile);
            _db.SaveChanges();

            return View("View",_db.Profile.AsNoTracking());
        }
    }

}

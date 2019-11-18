using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.WEB.Controllers
{
    public class TryController : Controller
    {
        private readonly ApplicationContext _db;

        public TryController(ApplicationContext db)
        {
            _db = db;
        }
        [HttpGet("/api/try")]
        public IEnumerable<Make> GetMakes()
        {
            return _db.Makes.ToList();
        }

    }
}
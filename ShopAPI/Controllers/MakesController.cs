using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.BLL.DTO;
using Shop.BLL.Services;

namespace ShopAPI.WEB.Controllers
{
    public class MakesController : Controller
    {
        private MakesService makeService;

        public MakesController(MakesService makeService)
        {
            this.makeService = makeService;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeDTO> GetMakes()
        {
            return makeService.GetMakes();
        }
    }
}
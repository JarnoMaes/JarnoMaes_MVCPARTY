using JarnoMaes_MVCPARTY.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarnoMaes_MVCPARTY.Controllers
{
    public class VisitorsController : Controller
    {
        static List<VisitorsModel> _visitors = new List<VisitorsModel>();
  
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult Create(VisitorsModel visitor)  //Ruben heeft tip gegeven.
        {
            try
            {
                _visitors.Add(visitor);
                ModelState.Clear();
                return View();
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Summary()
        {
            
            TempData["TotalVisitors"] = _visitors.Count;        
            TempData["IsFamily"] = _visitors.Where(x => x.IsFamily).ToList().Count;
            TempData["MinimumAge"] = _visitors.Min(x => x.Age);
            TempData["MaximumAge"] = _visitors.Max(x => x.Age);

            return View("Summary");
        }
    }
}

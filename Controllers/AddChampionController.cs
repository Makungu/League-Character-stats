using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using leagueChampionStats.Models;


namespace leagueChampionStats.Controllers
{
    public class AddChampionController: Controller
    {
        public AddChampionController()
        {

        }

        public IActionResult Submit(string name, string role, string type, string region)
        {
            ViewData["Name"] = name;
            ViewData["Role"] = role;
            ViewData["Type"] = type;
            ViewData["Region"] = region;
            return View("AddChampion");
        }
        public IActionResult AddChampion()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;
using System;
using System.Data.Entity;
using System.Linq;
//using Microsoft.EntityFrameworkCore.Relational;


namespace leagueChampionStats.Controllers
{
    public class ManageChampionsController: Controller
    {
        championContext context = new championContext();
        public ManageChampionsController()
        {

        }

        public IActionResult SubmitAdd(string name, string role, string type, string region)
        {
            champion champResult = context.champions.FirstOrDefault(r => r.name == name);
           if (champResult == null)
           {
                champion champ = new champion()
                {
                    name = name,
                    role = role,
                    type = type,
                    region = region
                }; 
                context.champions.Add(champ);
                context.SaveChanges();
           }
            return View("AddChampion");
        }

        public IActionResult submitEdit(string name, string role, string type, string region)
        {
            
            champion champ = context.champions.FirstOrDefault(r => r.name == name);
            champ.name =name;
            champ.role = role;
            champ.type = type;
            champ.region = region;
            context.SaveChanges();
            return View("EditChampion");
        }

        public IActionResult submitRemove(string name)
        {
            champion champ = context.champions.FirstOrDefault(r => r.name == name);
            context.champions.Remove(champ);
            context.SaveChanges();
            return View("RemoveChampion");
        }

        public IActionResult AddChampion()
        {
            return View("AddChampion");
        }

        public IActionResult EditChampion()
        {
            
            return View("EditChampion");
        }

        public IActionResult RemoveChampion()
        {
            return View("RemoveChampion");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
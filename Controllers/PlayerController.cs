using Microsoft.AspNetCore.Mvc;
using WebAppPlayer.Models;

namespace WebAppPlayer.Controllers
{
    public class PlayerController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() {PId=1,PName="Virat Kohli",PCountry="RCB",PType="Batsman"},
            new Player() {PId=2,PName="AB DEVELLIERS",PCountry="DC",PType="Batsman/WK"},
            new Player() {PId=3,PName="Siraj",PCountry="SRH",PType="Bowler"},

        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        public IActionResult Create(Player Play)
        {
            if(ModelState.IsValid)
            {
                players.Add(Play);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

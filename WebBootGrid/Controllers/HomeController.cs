using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBootGrid.Models;

namespace WebBootGrid.Controllers
{
    public class HomeController : Controller
    {
        private List<Produtos> Produtos { get; set; }
        public HomeController()
        {
            Produtos = new List<Produtos>();
        }
        public IActionResult Index()
        {
            Produtos.Add(new Produtos { ID = 1, Link = "Madalena@shshlsdahldashlka.com", Received = "No", Sender = "sim" });

            Produtos.Add(new Produtos { ID = 2, Link = "john@shshlsdahldashlka.com", Received = "No", Sender = "sim" });
            Produtos.Add(new Produtos { ID = 3, Link = "Tatiane@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 4, Link = "Davi@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 1, Link = "Madalena@shshlsdahldashlka.com", Received = "No", Sender = "sim" });

            Produtos.Add(new Produtos { ID = 2, Link = "john@shshlsdahldashlka.com", Received = "No", Sender = "sim" });
            Produtos.Add(new Produtos { ID = 3, Link = "Tatiane@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 4, Link = "Davi@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 1, Link = "Madalena@shshlsdahldashlka.com", Received = "No", Sender = "sim" });

            Produtos.Add(new Produtos { ID = 2, Link = "john@shshlsdahldashlka.com", Received = "No", Sender = "sim" });
            Produtos.Add(new Produtos { ID = 3, Link = "Tatiane@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 4, Link = "Davi@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 1, Link = "Madalena@shshlsdahldashlka.com", Received = "No", Sender = "sim" });

            Produtos.Add(new Produtos { ID = 2, Link = "john@shshlsdahldashlka.com", Received = "No", Sender = "sim" });
            Produtos.Add(new Produtos { ID = 3, Link = "Tatiane@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });
            Produtos.Add(new Produtos { ID = 4, Link = "Davi@shshlsdahldashlka.com", Received = "Sim", Sender = "No" });

            return View(Produtos);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

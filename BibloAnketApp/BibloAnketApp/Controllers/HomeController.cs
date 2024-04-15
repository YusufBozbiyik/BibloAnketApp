using Microsoft.AspNetCore.Mvc;
using BibloAnketApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibloAnketApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            HomePageViewModel x = new HomePageViewModel {
                Kategoriler = Fabrika.Kategoriler,
                HaftanınAnketleri = Fabrika.Anketler.Where(a => a.HaftanınAnketiMi == true).ToList()

            };
            return View(x);
        }

        public IActionResult Listele(int? id)
        {
            
            ListeleViewModel x = new ListeleViewModel
            {
                Anketler = Fabrika.Anketler.Where(a => a.KategoriId == id).ToList(),
                Kategoriler = Fabrika.Kategoriler,
            };
            var kategori = Fabrika.Kategoriler.FirstOrDefault(k => k.Id == id);
            ViewBag.secilenKategori = kategori.Ad;
            ViewBag.kategoriId = kategori.Id;
            return View(x);
        }
        public IActionResult Detay(int? id)
        {
            var anket = Fabrika.Anketler.FirstOrDefault(a => a.Id == id);
            if (anket != null) 
            {
                
                return View(anket);
            }            
            return RedirectToAction("Index");
        }
    }
}

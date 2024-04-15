using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibloAnketApp.Models
{
    public class HomePageViewModel
    {
        public List<Kategori> Kategoriler { get; set; }
        public List<Anket> HaftanınAnketleri { get; set; }
    }
}

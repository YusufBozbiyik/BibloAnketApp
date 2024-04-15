using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibloAnketApp.Models
{
    public class Anket
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public bool HaftanınAnketiMi { get; set; }
        public string Ad { get; set; }
        public string Resim { get; set; }
        public string KısaAciklama { get; set; }
        public string DetayAciklamaUst { get; set; }
        public string DetayAciklamaAlt { get; set; }
    }
}

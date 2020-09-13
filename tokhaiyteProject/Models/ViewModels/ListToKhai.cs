using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tokhaiyteProject.Models.ViewModels
{
    public class ListToKhai
    {
        public int id { get; set; }
        
        public string Gate { get; set; }

        public string FullName { get; set; }

        public int BirthYear { get; set; }

        public string Gender { get; set; }

        public string VietNam { get; set; }
        public int HoChieu { get; set; }
        public bool tauBay { get; set; }
        public bool tauThuyen { get; set; }
        public bool oTo { get; set; }
        public string other { get; set; }
        public string Sohieu { get; set; }
        public int SoGhet { get; set; }

        public int startDay { get; set; }

        public int startMonth { get; set; }

        public int startYear { get; set; }

        public int entryDay { get; set; }

        public int entryMonth { get; set; }

        public int entryYear { get; set; }

        public string VietNam_s { get; set; }

        public string Tinhs { get; set; }
        public string VietNam_e { get; set; }

        public string Tihhe { get; set; }
        public string denquocgia { get; set; }

        public string Province { get; set; }

        public string District { get; set; }

        public string Ward { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public bool Sot { get; set; }

        public bool Ho { get; set; }

        public bool Khotho { get; set; }


        public bool Dauhong { get; set; }

        public bool Non { get; set; }

        public bool Tieuchay { get; set; }

        public bool xuatHuyet { get; set; }

        public bool NoiBan { get; set; }

        public string vacxin { get; set; }

        public bool dongvat { get; set; }

        public bool tiepxuc { get; set; }
    }
}

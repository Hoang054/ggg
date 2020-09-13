using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tokhaiyteProject.Models.Entities
{
    public class tokhaimodel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int GateId { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int BirthYear { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string VietNam { get; set; }
        public int HoChieu { get; set; }
        public bool tauBay { get; set; }
        public bool tauThuyen { get; set; }
        public bool oTo { get; set; }
        public string other { get; set; }
        public string Sohieu { get; set; }
        public int SoGhet { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int startDay { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int startMonth { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int startYear { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int entryDay { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int entryMonth { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int entryYear { get; set; }

        public string VietNam_s { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int IdTinhs { get; set; }
        public string VietNam_e { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int IdTihhe { get; set; }
        public string denquocgia { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int idProvince { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int idDistrict { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public int idWard { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Sot { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Ho { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Khotho { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Dauhong { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Non { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool Tieuchay { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool xuatHuyet { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool NoiBan { get; set; }

        public string vacxin { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool dongvat { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public bool tiepxuc { get; set; }
    }
}

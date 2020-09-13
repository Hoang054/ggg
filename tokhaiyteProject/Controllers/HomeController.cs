using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tokhaiyteProject.Models;
using tokhaiyteProject.Models.Entities;
using tokhaiyteProject.Models.ViewModels;
using tokhaiyteProject.Services;

namespace tokhaiyteProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ItokhaiService tokhaiService;

        public HomeController(ILogger<HomeController> logger, ItokhaiService tokhaiService)
        {
            _logger = logger;
            this.tokhaiService = tokhaiService;
        }

        public IActionResult Index()
        {
            var model = new toKhaiView();
            model.Provinces = tokhaiService.GetProvinces();
            return View(model);
            //return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/Districts/{idProvince}")]
        public IActionResult GetDistricts(int idProvince)
        {
            var districts = tokhaiService.GetDistricts(idProvince);
            return Json(new { districts });
        }

        [Route("Home/Wards/{idDistrict}/{idProvince}")]
        public IActionResult GetWards(int idDistrict, int idProvince)
        {
            var wards = tokhaiService.GetWards(idProvince, idDistrict);
            return Json(new { wards });
        }
        [HttpPost]
        public IActionResult Index(tokhai model)
        {
            if (ModelState.IsValid)
            {
                var toKhai = new tokhaimodel()
                {
                    Address = model.Address,
                    BirthYear = model.BirthYear,
                    Email = model.Email,
                    FullName = model.FullName,
                    Gender = model.Gender,
                    GateId = model.GateId,
                    VietNam = model.VietNam,
                    HoChieu = model.HoChieu,
                    tauBay = model.tauBay,
                    tauThuyen = model.tauThuyen,
                    oTo = model.oTo,
                    other = model.other,
                    Sohieu = model.Sohieu,
                    SoGhet = model.SoGhet,
                    startDay = model.startDay,
                    startMonth = model.startMonth,
                    startYear = model.startYear,
                    VietNam_e = model.VietNam_e,
                    IdTihhe = model.IdTihhe,
                    IdTinhs = model.IdTinhs,
                    VietNam_s = model.VietNam_s,
                    denquocgia = model.denquocgia,
                    idProvince = model.idProvince,
                    idDistrict = model.idDistrict,
                    idWard = model.idWard,
                    PhoneNumber = model.PhoneNumber,
                    Sot = model.Sot,
                    Ho = model.Ho,
                    Khotho = model.Khotho,
                    Dauhong = model.Dauhong,
                    Non = model.Non,
                    Tieuchay = model.Tieuchay,
                    xuatHuyet = model.xuatHuyet,
                    NoiBan = model.NoiBan,
                    vacxin = model.vacxin,
                    tiepxuc = model.tiepxuc,
                    dongvat = model.dongvat,
                    entryDay = model.entryDay,
                    entryMonth = model.entryMonth,
                    entryYear = model.entryYear
                };
                var tokhaiid = tokhaiService.createToKhai(toKhai);
                if(tokhaiid > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "System error, please try again later!");
            }
            var tokhaiView = new toKhaiView();
            return View(tokhaiView);
        }
        public IActionResult List()
        {
            var ToKhai = new List<ListToKhai>();
            ToKhai = tokhaiService.GetToKhais().ToList();
            return View(ToKhai);
        }
        [Route("/Home/Delete/{idToKhai}")]
        public IActionResult DeleteToKhai(int idToKhai)
        {
            var deleToKhai = tokhaiService.DeleteToKhai(idToKhai);
            return Json(new { deleToKhai });
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = tokhaiService.GetTokhai(id);
            var ToKhaiEdit = new EditToKhai();
            if(model != null)
            {
                ToKhaiEdit.id = model.id;
                ToKhaiEdit.Address = model.Address;
                ToKhaiEdit.BirthYear = model.BirthYear;
                ToKhaiEdit.Email = model.Email;
                ToKhaiEdit.FullName = model.FullName;
                ToKhaiEdit.Gender = model.Gender;
                ToKhaiEdit.GateId = model.GateId;
                ToKhaiEdit.VietNam = model.VietNam;
                ToKhaiEdit.HoChieu = model.HoChieu;
                ToKhaiEdit.tauBay = model.tauBay;
                ToKhaiEdit.tauThuyen = model.tauThuyen;
                ToKhaiEdit.oTo = model.oTo;
                ToKhaiEdit.other = model.other;
                ToKhaiEdit.Sohieu = model.Sohieu;
                ToKhaiEdit.SoGhet = model.SoGhet;
                ToKhaiEdit.startDay = model.startDay;
                ToKhaiEdit.startMonth = model.startMonth;
                ToKhaiEdit.startYear = model.startYear;
                ToKhaiEdit.VietNam_e = model.VietNam_e;
                ToKhaiEdit.IdTihhe = model.IdTihhe;
                ToKhaiEdit.IdTinhs = model.IdTinhs;
                ToKhaiEdit.VietNam_s = model.VietNam_s;
                ToKhaiEdit.denquocgia = model.denquocgia;
                ToKhaiEdit.idProvince = model.idProvince;
                ToKhaiEdit.idDistrict = model.idDistrict;
                ToKhaiEdit.idWard = model.idWard;
                ToKhaiEdit.PhoneNumber = model.PhoneNumber;
                ToKhaiEdit.Sot = model.Sot;
                ToKhaiEdit.Ho = model.Ho;
                ToKhaiEdit.Khotho = model.Khotho;
                ToKhaiEdit.Dauhong = model.Dauhong;
                ToKhaiEdit.Non = model.Non;
                ToKhaiEdit.Tieuchay = model.Tieuchay;
                ToKhaiEdit.xuatHuyet = model.xuatHuyet;
                ToKhaiEdit.NoiBan = model.NoiBan;
                ToKhaiEdit.vacxin = model.vacxin;
                ToKhaiEdit.tiepxuc = model.tiepxuc;
                ToKhaiEdit.dongvat = model.dongvat;
                ToKhaiEdit.entryDay = model.entryDay;
                ToKhaiEdit.entryMonth = model.entryMonth;
                ToKhaiEdit.entryYear = model.entryYear;
                ToKhaiEdit.Provinces = tokhaiService.GetProvinces();
                ToKhaiEdit.Districts = tokhaiService.GetDistricts(ToKhaiEdit.idProvince);
                ToKhaiEdit.Wards = tokhaiService.GetWards(ToKhaiEdit.idProvince, ToKhaiEdit.idDistrict);
            }
            return View(ToKhaiEdit);
        }
        [HttpPost]
        public IActionResult Edit(UpdateToKhai model)
        {
            if (ModelState.IsValid)
            {
                if (tokhaiService.UpdateToKhai(model) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "System error, please try again later!");
            }
            var editToKhai = new EditToKhai();
            return View(editToKhai);
        }
    }
}

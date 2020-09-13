using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using tokhaiyteProject.Models;
using tokhaiyteProject.Models.Entities;
using tokhaiyteProject.Models.ViewModels;

namespace tokhaiyteProject.Services
{
    public class tokhaiService : ItokhaiService
    {
        private readonly tokhaiyteDbContext context;

        public tokhaiService(tokhaiyteDbContext context)
        {
            this.context = context;
        }

        public int createToKhai(tokhaimodel tokhai)
        {
            context.tokhaimodels.Add(tokhai);
            return context.SaveChanges();
        }

        public int DeleteToKhai(int id)
        {
            var tokhai = context.tokhaimodels.FirstOrDefault(e => e.id == id);
            if (tokhai != null)
            {
                context.tokhaimodels.Remove(tokhai);
                return context.SaveChanges();
            }
            return -1;
        }

        public IEnumerable<District> GetDistricts(int idProvince)
        {
            return context.Districts.Where(e => e._province_id == idProvince).ToList();
        }

        public IEnumerable<Province> GetProvinces()
        {
            return context.Provinces.ToList();
        }

        public tokhaimodel GetTokhai(int id)
        {
            return context.tokhaimodels.FirstOrDefault(e => e.id == id);
        }

        public IEnumerable<ListToKhai> GetToKhais()
        {
            IEnumerable<ListToKhai> ToKhai = new List<ListToKhai>();
            ToKhai = (from t in context.tokhaimodels
                      join g in context.Gates on t.GateId equals g.id
                      join p in context.Provinces on t.idProvince equals p.id
                      join d in context.Districts on t.idDistrict equals d.id
                      join w in context.Wards on t.idWard equals w.id
                      select (new ListToKhai()
                      {
                          id = t.id,
                          Address = t.Address,
                          BirthYear = t.BirthYear,
                          Email = t.Email,
                          FullName = t.FullName,
                          Gender = t.Gender,
                          Gate = $"{g.GateName }",
                          VietNam = t.VietNam,
                          HoChieu = t.HoChieu,
                          tauBay = t.tauBay,
                          tauThuyen = t.tauThuyen,
                          oTo = t.oTo,
                          other = t.other,
                          Sohieu = t.Sohieu,
                          SoGhet = t.SoGhet,
                          startDay = t.startDay,
                          startMonth = t.startMonth,
                          startYear = t.startYear,
                          VietNam_e = t.VietNam_e,
                          Tihhe = p._name,
                          Tinhs = p._name,
                          VietNam_s = t.VietNam_s,
                          denquocgia = t.denquocgia,
                          Province = p._name,
                          District = d._name,
                          Ward = w._name,
                          PhoneNumber = t.PhoneNumber,
                          Sot = t.Sot,
                          Ho = t.Ho,
                          Khotho = t.Khotho,
                          Dauhong = t.Dauhong,
                          Non = t.Non,
                          Tieuchay = t.Tieuchay,
                          xuatHuyet = t.xuatHuyet,
                          NoiBan = t.NoiBan,
                          vacxin = t.vacxin,
                          tiepxuc = t.tiepxuc,
                          dongvat = t.dongvat,
                          entryDay = t.entryDay,
                          entryMonth = t.entryMonth,
                          entryYear = t.entryYear
                      }));
            return ToKhai;
        }

        public IEnumerable<Ward> GetWards(int idProvince, int idDistrict)
        {
            if (idProvince != 0 && idDistrict != 0)
            {
                return context.Wards.Where(e => e._province_id == idProvince && e._district_id == idDistrict).ToList();
            }
            else if (idDistrict != 0)
            {
                return context.Wards.Where(e => e._district_id == idDistrict).ToList();
            }
            else if (idProvince != 0)
            {
                return context.Wards.Where(e => e._province_id == idProvince).ToList();
            }
            return context.Wards.ToList();
        }

        public int UpdateToKhai(UpdateToKhai model)
        {
            var tokhai = GetTokhai(model.id);
            if(tokhai == null)
            {
                return -1;
            }
            tokhai.id = model.id;
            tokhai.Address = model.Address;
            tokhai.BirthYear = model.BirthYear;
            tokhai.Email = model.Email;
            tokhai.FullName = model.FullName;
            tokhai.Gender = model.Gender;
            tokhai.GateId = model.GateId;
            tokhai.VietNam = model.VietNam;
            tokhai.HoChieu = model.HoChieu;
            tokhai.tauBay = model.tauBay;
            tokhai.tauThuyen = model.tauThuyen;
            tokhai.oTo = model.oTo;
            tokhai.other = model.other;
            tokhai.Sohieu = model.Sohieu;
            tokhai.SoGhet = model.SoGhet;
            tokhai.startDay = model.startDay;
            tokhai.startMonth = model.startMonth;
            tokhai.startYear = model.startYear;
            tokhai.VietNam_e = model.VietNam_e;
            tokhai.IdTihhe = model.IdTihhe;
            tokhai.IdTinhs = model.IdTinhs;
            tokhai.VietNam_s = model.VietNam_s;
            tokhai.denquocgia = model.denquocgia;
            tokhai.idProvince = model.idProvince;
            tokhai.idDistrict = model.idDistrict;
            tokhai.idWard = model.idWard;
            tokhai.PhoneNumber = model.PhoneNumber;
            tokhai.Sot = model.Sot;
            tokhai.Ho = model.Ho;
            tokhai.Khotho = model.Khotho;
            tokhai.Dauhong = model.Dauhong;
            tokhai.Non = model.Non;
            tokhai.Tieuchay = model.Tieuchay;
            tokhai.xuatHuyet = model.xuatHuyet;
            tokhai.NoiBan = model.NoiBan;
            tokhai.vacxin = model.vacxin;
            tokhai.tiepxuc = model.tiepxuc;
            tokhai.dongvat = model.dongvat;
            tokhai.entryDay = model.entryDay;
            tokhai.entryMonth = model.entryMonth;
            tokhai.entryYear = model.entryYear;
            context.Update(tokhai);
            return context.SaveChanges();
        }
    }
}

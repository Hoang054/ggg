using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tokhaiyteProject.Models.Entities;
using tokhaiyteProject.Models.ViewModels;

namespace tokhaiyteProject.Services
{
    public interface ItokhaiService
    {
        IEnumerable<Province> GetProvinces();
        IEnumerable<District> GetDistricts(int idProvince);
        IEnumerable<Ward> GetWards(int idProvince, int idDistrict);

        int createToKhai(tokhaimodel tokhai);
        IEnumerable<ListToKhai> GetToKhais();
        tokhaimodel GetTokhai(int id);
        int DeleteToKhai(int id);
        int UpdateToKhai(UpdateToKhai model);
    }
}

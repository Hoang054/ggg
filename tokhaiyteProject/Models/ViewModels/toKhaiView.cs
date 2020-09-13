using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tokhaiyteProject.Models.Entities;

namespace tokhaiyteProject.Models.ViewModels
{
    public class toKhaiView : tokhai
    {
        public toKhaiView()
        {
            Provinces = new List<Province>();
            Districts = new List<District>();
            Wards = new List<Ward>();
            Gates = new List<Gate>();
            Dates = new List<Date>();
            Months = new List<Month>();
            Years = new List<Year>();
        }
        public IEnumerable<Province> Provinces { get; set; }
        public IEnumerable<District> Districts { get; set; }
        public IEnumerable<Ward> Wards { get; set; }
        public IEnumerable<Gate> Gates { get; set; }
        public IEnumerable<Date> Dates { get; set; }
        public IEnumerable<Month> Months { get; set; }
        public IEnumerable<Year> Years { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels.ResponeAPI
{
    public  class DistrictResponse
    {
        public List<DataResponseDistrict> results { get; set; }
    }
    public class DataResponseDistrict
    {
        public int district_id { get; set; }
        public string district_name { get; set; }
        public string district_type { get; set; }
    }
}

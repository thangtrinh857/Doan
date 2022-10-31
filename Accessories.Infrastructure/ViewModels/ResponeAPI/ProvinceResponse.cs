using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels.ResponeAPI
{
    public class ProvinceResponse
    {
        public List<DataResponse> results { get; set; }
    }
    public class DataResponse
    {
        public int province_id { get; set; }
        public string province_name { get; set; }
    }
}

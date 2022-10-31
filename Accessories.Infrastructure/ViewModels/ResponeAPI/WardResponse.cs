using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels.ResponeAPI
{
    public class WardResponse
    {
        public List<DataResponseWard> results { get; set; }
    }
    public class DataResponseWard
    {
        public int ward_id { get; set; }
        public string ward_name { get; set; }
    }
}

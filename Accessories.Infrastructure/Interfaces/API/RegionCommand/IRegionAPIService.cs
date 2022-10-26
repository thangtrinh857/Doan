using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.Interfaces.API.RegionCommand
{
    public interface IRegionAPIService
    {
        Task<object> GetListProvinceByAPI();
        Task<object> GetListDistrictByProvinceId(string provinceId);
        Task<object> GetListWardByDistrictId(string districtId);

    }
}

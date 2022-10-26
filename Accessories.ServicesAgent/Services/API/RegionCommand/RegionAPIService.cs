using Accessories.Data.Context;
using Accessories.Infrastructure.Interfaces.API.RegionCommand;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Accessories.ServicesAgent.Services.API.RegionCommand
{
    public class RegionAPIService : BaseService, IRegionAPIService
    {
        public RegionAPIService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {
        }
        public async Task<object> GetListProvinceByAPI()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://vapi.vnappmob.com");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            var response = await httpClient.GetAsync("/api/province");
            var responseBody = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(responseBody);
            return data;
        }
        public async Task<object> GetListDistrictByProvinceId(string provinceId)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://vapi.vnappmob.com");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            var endpoint = "/api/province/district/" + provinceId;
            var response = await httpClient.GetAsync(endpoint);
            var responseBody = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(responseBody);
            return data;
        }
        public async Task<object> GetListWardByDistrictId(string districtId)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://vapi.vnappmob.com");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            var endpoint = "/api/province/ward/" + districtId;
            var response = await httpClient.GetAsync(endpoint);
            var responseBody = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(responseBody);
            return data;
        }
    }
}

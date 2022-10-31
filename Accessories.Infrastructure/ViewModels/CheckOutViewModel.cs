using Accessories.Domain.Models;
using Accessories.Infrastructure.ViewModels.ResponeAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels
{
    public class CheckOutViewModel
    {
        public UserEntity User { get; set; }
        public BillViewModel? Bill { get; set; }
        public ProvinceResponse? ProvinceResponse { get; set; }
        public DistrictResponse? DistrictResponse { get; set; }
        public WardResponse? WardResponse { get; set; }
        public string? ErrorMessage { get; set; }
        public string? ProvinceChooseId { get; set; }
        public string? DistrictChooseId { get; set; }
        public string? WardChooseId { get; set; }

    }
}

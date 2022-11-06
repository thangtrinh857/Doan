using Accessories.Domain.Models;
using Accessories.Infrastructure.Contents.MessageEnum;
using Accessories.Infrastructure.Interfaces.API.RegionCommand;
using Accessories.Infrastructure.Interfaces.BillCommand;
using Accessories.Infrastructure.Interfaces.CartProductCommand;
using Accessories.Infrastructure.Interfaces.PaymentCommand;
using Accessories.Infrastructure.ViewModels;
using Accessories.Infrastructure.ViewModels.ResponeAPI;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accessories.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly ICartProductService _cartProductService;
        private readonly IRegionAPIService _regionAPIService;
        private readonly IMapper _mapper;
        private readonly IPaymentService _paymentService;
        private readonly IBillService _billService;
        public CheckOutController(
            UserManager<UserEntity> userManager, 
            ICartProductService cartProductService,
            IMapper mapper,
            IPaymentService paymentService,
            IBillService billService,
            IRegionAPIService regionAPIService)
        {
            _userManager = userManager;
            _cartProductService = cartProductService;
            _regionAPIService = regionAPIService;
            _mapper = mapper;
            _paymentService = paymentService;
            _billService = billService;
        }
        [HttpGet]    
        public async Task<IActionResult> Index(int total, string provinceId, string districtId)
        {
            CheckOutViewModel checkOutViewModel = new CheckOutViewModel();
            var user = await _userManager.GetUserAsync(User);   
            if (user == null)
            {
                checkOutViewModel.ErrorMessage = MessageConst.Not_Found_User;
                return View("Index", checkOutViewModel);
            }
            BillViewModel bill = new BillViewModel();
            var province = await _regionAPIService.GetListProvinceByAPI();
            bill.Total = total;
            bill.CartProducts =await _cartProductService.GetCartProductsByUserIdAsync(user.Id);
            checkOutViewModel.User = user;
            checkOutViewModel.Bill = bill;
            checkOutViewModel.ProvinceResponse = _mapper.Map<ProvinceResponse>(province);
            if (provinceId != null)
            {
                checkOutViewModel.ProvinceChooseId = provinceId;
                if (provinceId.Length == 1) provinceId = "0" + provinceId;
                var district = await _regionAPIService.GetListDistrictByProvinceId(provinceId);
                if (district != null)
                {
                    checkOutViewModel.DistrictResponse = _mapper.Map<DistrictResponse>(district);
                }
            }
            if (districtId != null && districtId != "0")
            {
                checkOutViewModel.DistrictChooseId = districtId;
                if (districtId.Length == 1) districtId = "0" + districtId;
                var ward = await _regionAPIService.GetListWardByDistrictId(districtId);
                if (ward != null)
                {
                    checkOutViewModel.WardResponse = _mapper.Map<WardResponse>(ward);
                }
            }
            return View("Views/CheckOut/Index.cshtml", checkOutViewModel);
        }
        [HttpPost]
        public IActionResult GetPaymentGatewaysApiVNPay(int total)
        {
            var paymentUrl = _paymentService.PaymentByVNPayGateway(total);
            return Json(paymentUrl);
        }
        [HttpPost]
        public async Task<IActionResult> GetPaymentGatewaysApiMomo(string userId, int total)
        {
            BillViewModel bill = new BillViewModel();
            bill.CartProducts = await _cartProductService.GetCartProductsByUserIdAsync(userId);
            bill.Total = total;
            var paymentUrl = _paymentService.PaymentByMomoGateway(bill);
            return Json(paymentUrl);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBill(int total, string userId)
        {
            var result = await _billService.CreateBillAsync(total, null, userId);
            if (!result) return Json(MessageConst.Message_Notice_Add_Fail);
            var cartProducts = await _cartProductService.GetCartProductsByUserIdAsync(userId);
            _cartProductService.ChangeStatusPaidProductByCart(cartProducts);
            return Json(MessageConst.Message_Notice_Add_Success);
        }
    }
}

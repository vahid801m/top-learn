using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.DTOs.Order;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Discount
{
    public class IndexModel : PageModel
    {
      private  IOrderService _ordersService;
        public IndexModel(IOrderService orderService)
        {
            _ordersService= orderService;
        }
        public List<TopLearn.DataLeyer.Entities.Order.Discount> Discount { get; set; }
        public void OnGet(string filterCode="",int pageId=1)
        {
           Discount = _ordersService.GetAllDiscount(filterCode,pageId);
        }
    }
}

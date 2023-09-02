using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs.Order;
using TopLearn.DataLeyer.Entities.Order;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int courseId);

        void UpdatePriceOrder(int orderId);

        Order GetOrderForUserPanel(string userName, int orderId);

        bool FinalyOrder(string userName, int orderId);
        bool IsUserInCourse(string userName, int courseId);

        List<Order> GetUserOrders(string userName);

        Order GetOrderById(int orderId);

        void UpdateOrder(Order order);

        #region Discount

        DiscountUseType UseDiscount(int orderId, String code);

        void AddDiscount(Discount discount);

        List<Discount> GetAllDiscount(string filterCode = "", int pageId = 1);

        Discount GetDiscountById(int discountId);

        void UpdateDiscount(Discount discount);

        bool IsExistCode(string code);
        #endregion
    }
}

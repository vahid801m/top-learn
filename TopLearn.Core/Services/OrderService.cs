using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs.Order;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLeyer.Entities.Order;

namespace TopLearn.Core.Services
{
    public class OrderService : IOrderService
    {
        private TopLearnContext _context;
        private IUserService _userService;

        public OrderService(TopLearnContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public void AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public int AddOrder(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUsername(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var course = _context.Courses.Find(courseId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = course.CoursePrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            CourseId = courseId,
                            Count = 1,
                            Price = course.CoursePrice
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails.FirstOrDefault(d => d.OrderId == order.OrderId && d.CourseId == courseId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        CourseId = courseId,
                        Price = course.CoursePrice,
                    };
                    _context.OrderDetails.Add(detail);

                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }


            return order.OrderId;

        }

        public bool FinalyOrder(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUsername(userName);
            var order = _context.Orders.Include(c => c.OrderDetails).ThenInclude(v => v.Course).FirstOrDefault(c => c.OrderId == orderId && c.UserId == userId);
            if (order == null || order.IsFinaly)
            {
                return false;
            }
            if (_userService.BalanceUserWallet(userName) >= order.OrderSum)
            {
                order.IsFinaly = true;

                _userService.AddWallet(new DataLayer.Entities.Wallet.Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شما" + order.OrderId,
                    TypeId = 2,
                    UserId = userId,
                });
                _context.Orders.Update(order);

                foreach (var detail in order.OrderDetails)
                {
                    _context.UserCourses.Add(new DataLayer.Entities.Course.UserCourse()
                    {
                        CourseId = detail.CourseId,
                        UserId = userId,

                    });
                    // دلیل این حلقه فور ایچ چیه 

                }
                _context.SaveChanges();
                return true;



            }
            return false;
        }

        public List<Discount> GetAllDiscount(string filterCode = "", int pageId = 1)
        {
            IQueryable<Discount> result = _context.Discounts;


            if (!string.IsNullOrEmpty(filterCode))
            {
                result = result.Where(c => c.DiscountCode.Contains(filterCode));
            }


            return result.ToList();


            //int take = 2;
            //int skip = (pageId - 1) - take;

            //ShowItemDiscount discount = new ShowItemDiscount();

            //discount.CurrentPage = pageId;
            //discount.PageCount = result.Count() / take;
            //discount.Discounts = result.Skip(skip).Take(take).ToList();

            //return discount;

        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.Find(discountId);
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public Order GetOrderForUserPanel(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUsername(userName);

            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Course)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public List<Order> GetUserOrders(string userName)
        {
            //if (take == 0)
            //    take = 8;


            int userId = _userService.GetUserIdByUsername(userName); // ایدی یوزر میاد بیرون ازش

            //int skip = (pagId - 1) * take;  // صفحه اصلی عددش

            return _context.Orders.Where(c => c.UserId == userId).ToList();  // ثبت یوزر



        }
        [Authorize]
        public bool IsUserInCourse(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUsername(userName);

            return _context.UserCourses.Any(c => c.UserId == userId && c.CourseId == courseId);
        }

        public void UpdateDiscount(Discount discount)
        {
            _context.Discounts.Update(discount);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public DiscountUseType UseDiscount(int orderId, string code)
        {
            var discount = _context.Discounts.SingleOrDefault(c => c.DiscountCode == code);

            if (discount == null)
            {
                return DiscountUseType.NotFound;
            }
            if (discount != null && discount.StartDate < DateTime.Now)
            {
                return DiscountUseType.ExpireDate;
            }
            if (discount != null && discount.EndDate >= DateTime.Now)
            {
                return DiscountUseType.ExpireDate;
            }
            if (discount != null && discount.UsableCount < 1)
            {
                return DiscountUseType.Finished;
            }
            var order = GetOrderById(orderId);
            if (_context.UserDiscountCodes.Any(c => c.UserId == order.UserId && c.DiscountId == discount.DiscountId))
            {
                return DiscountUseType.UserUsed;
            }
            var percent = (order.OrderSum * discount.DisCountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);

            if (discount.UsableCount > 1)
            {
                discount.UsableCount -= 1;
            }
            _context.Discounts.Update(discount);
            _context.UserDiscountCodes.Add(new DataLeyer.Entities.User.UserDiscountCode
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId,
            });
            _context.SaveChanges();
            return DiscountUseType.Success;
        }

        bool IOrderService.IsExistCode(string code)
        {
            return _context.Discounts.Any(c => c.DiscountCode == code);
        }
    }
}

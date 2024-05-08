using ASP.Net_Mvc_core.Models;
using ASP.Net_Mvc_core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.Net_Mvc_core.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("Order is null"); 
            }

            _orderRepository.PlaceOrder(order);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ShowOrderDetails(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order == null)
            {
                return NotFound(); 
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult DisplayBill(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order == null)
            {
                return NotFound(); 
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult DisplayCustomerDetails(DateTime orderDate)
        {
            var customer = _orderRepository.GetCustomerByOrderDate(orderDate);
            if (customer == null)
            {
                return NotFound(); 
            }

            ViewBag.OrderDate = orderDate.ToShortDateString();
            return View(customer);
        }

        [HttpGet]
        public IActionResult ShowCustomerWithHighestOrder()
        {
            var customer = _orderRepository.GetCustomerWithHighestOrder();
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}

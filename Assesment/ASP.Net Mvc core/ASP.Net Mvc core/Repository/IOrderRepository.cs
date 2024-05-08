using ASP.Net_Mvc_core.Models;

namespace ASP.Net_Mvc_core.Repository
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        void PlaceOrder(Order order);
        // Add other methods as needed
        IEnumerable<Order> GetOrdersByCustomerId(string customerId);
        Customer GetCustomerByOrderDate(DateTime orderDate);
        Customer GetCustomerWithHighestOrder();
    }

}

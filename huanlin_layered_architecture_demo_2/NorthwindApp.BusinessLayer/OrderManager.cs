using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindApp.DataAccess;
using NorthwindApp.Domain;
using NorthwindApp.Domain.Model;

namespace NorthwindApp.BusinessLogic
{
    public class OrderManager
    {
        private IOrderRepository orderRepository;

        public OrderManager()
        {
            // TODO: Use IoC container to get the repository instance, 
            //       so that we can easily replace the implementation in the future.
            orderRepository = new OrderRepository();
        }

        public Order GetByID(int id)
        {
            return orderRepository.GetByID(id);
        }

        public void Insert(Order newOrder)
        {
            orderRepository.Insert(newOrder);
        }

        public IEnumerable<Order> GetOrders()
        {
            return orderRepository.GetAll();
        }
    }
}

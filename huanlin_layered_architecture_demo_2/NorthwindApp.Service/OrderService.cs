using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindApp.Domain;
using NorthwindApp.Domain.Model;
using NorthwindApp.BusinessLogic;
 
namespace NorthwindApp.Service
{
	public class OrderService
	{
        private OrderManager orderManager;

		public OrderService()
		{
            orderManager = new OrderManager();
            Order newOrder = new Order(1);
            orderManager.Insert(newOrder);
		}

		public Order GetByID(int id)
		{
            return orderManager.GetByID(id);
		}

		public IEnumerable<Order> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
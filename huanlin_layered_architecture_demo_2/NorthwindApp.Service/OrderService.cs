using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindApp.Domain;
using NorthwindApp.DataAccess;
 
namespace NorthwindApp.Service
{
	public class OrderService
	{
		private IOrderRepository orderRepository;

		public OrderService()
		{
			orderRepository = new OrderRepository();
		}

		public Order GetByID(int id)
		{
			return orderRepository.GetByID(id);
		}

		public IEnumerable<Order> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
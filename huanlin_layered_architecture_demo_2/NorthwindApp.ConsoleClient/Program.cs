using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using NorthwindApp.Domain;
using NorthwindApp.Service;

namespace NorthwindApp.ConsoleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			OrderService orderService = new OrderService();
			Order order = orderService.GetByID(1);
			Console.WriteLine("Customer: " + order.CustomerID);
			Console.WriteLine("ShipName: " + order.ShipName);
			Console.WriteLine("OrderDat: " + order.OrderDate.ToString());

		}
	}
}
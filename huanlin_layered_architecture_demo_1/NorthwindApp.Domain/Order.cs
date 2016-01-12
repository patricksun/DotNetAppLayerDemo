using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Domain
{
	[Serializable]
	public class Order
	{
		public Int32 OrderID { get; set; }
		public String CustomerID { get; set; }
		public Int32 EmployeeID { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime RequiredDate { get; set; }
		public DateTime ShippedDate { get; set; }
		public Int32 ShipVia { get; set; }
		public Decimal Freight { get; set; }
		public String ShipName { get; set; }
		public String ShipAddress { get; set; }
		public String ShipCity { get; set; }
		public String ShipRegion { get; set; }
		public String ShipPostalCode { get; set; }
		public String ShipCountry { get; set; }
	}
}
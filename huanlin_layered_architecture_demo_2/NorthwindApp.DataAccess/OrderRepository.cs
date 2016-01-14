using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

using System.Data.Entity;

using NorthwindApp.Domain.Model;

namespace NorthwindApp.DataAccess
{
	public class OrderRepository : IOrderRepository
	{
        private Microsoft.Practices.EnterpriseLibrary.Data.Database database;
//        private DbContext dbcontext;
        private NorthwindModelEntities dbContext2;

		public OrderRepository()
		{
            dbContext2 = new NorthwindModelEntities();
		}

		public Domain.Model.Order GetByID(int id)
		{
            DbSet<Order> orders = dbContext2.Orders;
            var findOrder = orders.Find(1);
            return findOrder;
		}

        public IEnumerable<Domain.Model.Order> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Order newOrder)
		{
            dbContext2.AddOrder(newOrder);
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
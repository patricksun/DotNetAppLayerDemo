using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

using System.Data.Entity;


namespace NorthwindApp.DataAccess
{
	public class OrderRepository : IOrderRepository
	{
        private Microsoft.Practices.EnterpriseLibrary.Data.Database database;
        private DbContext dbcontext;

		public OrderRepository()
		{

            database = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase("BloggingModel");
            BloggingModel dbcontext = new BloggingModel();
            DbSet<Blog> aaa = dbcontext.Blogs;
            
		}

		public Domain.Order GetByID(int id)
		{

//			string sql = String.Format("select * from Blogs where BlogId={0}", id);
            string sql = String.Format("select * from Posts");
            IDataReader rdr = database.ExecuteReader(CommandType.Text, sql);
            if (rdr.Read())
			{
				IRowMapper<Domain.Order> mapper = MapBuilder<Domain.Order>.BuildAllProperties();
				Domain.Order order = mapper.MapRow(rdr);
				return order;
			}
			return null;
		}

		public IEnumerable<Domain.Order> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert()
		{
			throw new NotImplementedException();
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
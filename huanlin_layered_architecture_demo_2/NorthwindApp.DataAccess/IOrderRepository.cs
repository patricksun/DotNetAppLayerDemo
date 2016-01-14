using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindApp.Domain.Model;
 
namespace NorthwindApp.DataAccess
{
    public interface IOrderRepository
    {
        Order GetByID(int id);
        IEnumerable<Order> GetAll();
        void Insert(Order newOrder);
        void Delete();
        void Update();
        void Save();
    }
}
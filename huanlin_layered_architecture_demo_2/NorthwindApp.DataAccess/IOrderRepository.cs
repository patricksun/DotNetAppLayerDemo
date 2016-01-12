using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindApp.Domain;
 
namespace NorthwindApp.DataAccess
{
    public interface IOrderRepository
    {
        Order GetByID(int id);
        IEnumerable<Order> GetAll();
        void Insert();
        void Delete();
        void Update();
        void Save();
    }
}
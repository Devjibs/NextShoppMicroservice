using Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<OrderEntity>
    {
        Task<IEnumerable<OrderEntity>> GetOrdersByUserName(string userName);
    }
}

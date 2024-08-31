using LearningDesignPattern.Data;
using LearningDesignPattern.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace LearningDesignPattern.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IAppDbContext _context;
        public OrderRepository(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}

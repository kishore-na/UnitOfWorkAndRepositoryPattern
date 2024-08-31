using LearningDesignPattern.Data;
using LearningDesignPattern.Repository;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace LearningDesignPattern.UnitOfWork
{
    public class UnitOfWork1 : IUnitOfWork
    {
        private readonly IAppDbContext _context;
        public IOrderRepository Orders { get; private set; }

        public UnitOfWork1(IAppDbContext context)
        {
            _context = context;
            Orders = new OrderRepository(context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_context is IDisposable disposableContext)
            {
                disposableContext.Dispose();
            }
        }
    }
}

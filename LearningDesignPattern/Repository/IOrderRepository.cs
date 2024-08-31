using LearningDesignPattern.Models;

namespace LearningDesignPattern.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}

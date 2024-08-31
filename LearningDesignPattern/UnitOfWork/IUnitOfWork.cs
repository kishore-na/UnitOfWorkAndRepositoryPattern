using LearningDesignPattern.Repository;

namespace LearningDesignPattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        Task<int> CompleteAsync();
    }
}

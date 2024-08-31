using LearningDesignPattern.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LearningDesignPattern.Data
{
    public interface IAppDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

}

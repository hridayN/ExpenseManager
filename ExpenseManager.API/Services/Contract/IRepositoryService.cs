using ExpenseManager.API.Infrastructure.Contracts;
using ExpenseManager.API.Infrastructure.Entities;

namespace ExpenseManager.API.Services.Contract
{
    /// <summary>
    /// Repository interface
    /// </summary>
    public interface IRepositoryService
    {
        /// <summary>
        /// Expense Repository
        /// </summary>
        IRepository<ExpenseEntity> ExpenseRepository { get; }
    }
}

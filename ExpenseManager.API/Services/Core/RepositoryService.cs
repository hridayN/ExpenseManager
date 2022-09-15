using ExpenseManager.API.Infrastructure.Contracts;
using ExpenseManager.API.Infrastructure.Entities;
using ExpenseManager.API.Services.Contract;

namespace ExpenseManager.API.Services.Core
{
    /// <summary>
    /// RepositoryService class
    /// </summary>
    public class RepositoryService : IRepositoryService
    {
        /// <summary>
        /// _expenseRepository variable
        /// </summary>
        private readonly IRepository<ExpenseEntity> _codeListRepository;

        /// <summary>
        /// ExpenseRepository
        /// </summary>
        public IRepository<ExpenseEntity> ExpenseRepository { get => this._codeListRepository; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="codeListRepository"></param>
        public RepositoryService(IRepository<ExpenseEntity> codeListRepository)
        {
            _codeListRepository = codeListRepository;
        }
    }
}

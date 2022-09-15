using AutoMapper.Internal.Mappers;
using ExpenseManager.API.DTO;
using ExpenseManager.API.Infrastructure.Contracts;
using ExpenseManager.API.Infrastructure.Entities;
using ExpenseManager.API.Mapper;
using ExpenseManager.API.Services.Contract;
using System.Runtime.Serialization;

namespace ExpenseManager.API.Services.Core
{
    /// <summary>
    /// Expense Service
    /// </summary>
    public class ExpenseService : IExpenseService
    {
        /// <summary>
        /// Expense repository variable
        /// </summary>
        private readonly IRepository<ExpenseEntity> _expenseRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="expenseRepository"></param>
        public ExpenseService(IRepository<ExpenseEntity> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        /// <summary>
        /// SearchExpenses method
        /// </summary>
        /// <param name="searchExpensesRequest"></param>
        /// <returns></returns>
        public Task<SearchExpensesResponse> SearchExpenses(SearchExpensesRequest searchExpensesRequest)
        {
            SearchExpensesResponse searchExpensesResponse = new SearchExpensesResponse();
            ExpenseEntity expenseEntity = ObjectMapper.Mapper.Map<SearchExpensesRequest, ExpenseEntity>(searchExpensesRequest);
            expenseEntity.CategoryId = (int)searchExpensesRequest.Expense.Category.Id;


            return searchExpensesResponse;
        }
    }
}

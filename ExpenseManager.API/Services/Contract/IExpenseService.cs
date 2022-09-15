using ExpenseManager.API.DTO;

namespace ExpenseManager.API.Services.Contract
{
    /// <summary>
    /// Interface for reference data 
    /// </summary>
    public interface IExpenseService
    {
        /// <summary>
        /// SearchExpenses method
        /// </summary>
        /// <param name="searchExpensesRequest"></param>
        /// <returns></returns>
        public Task<SearchExpensesResponse> SearchExpenses(SearchExpensesRequest searchExpensesRequest);
    }
}

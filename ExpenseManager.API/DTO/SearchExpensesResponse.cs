using ExpenseManager.API.DTO.Base;
using ExpenseManager.API.Models;

namespace ExpenseManager.API.DTO
{
    /// <summary>
    /// Model for search expense response
    /// </summary>
    public class SearchExpensesResponse : BaseResponse
    {
        /// <summary>
        /// Searched expenses
        /// </summary>
        public IEnumerable<Expense> Expenses { get; set; }
    }
}

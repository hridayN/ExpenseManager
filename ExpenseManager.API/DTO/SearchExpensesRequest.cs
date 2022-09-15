using ExpenseManager.API.DTO.Base;
using ExpenseManager.API.Models;

namespace ExpenseManager.API.DTO
{
    /// <summary>
    /// Model for search expense request
    /// </summary>
    public class SearchExpensesRequest : BaseRequest
    {
        /// <summary>
        /// Expense to be searched
        /// </summary>
        public Expense Expense { get; set; }
    }
}

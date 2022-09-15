using ExpenseManager.API.DTO.Base;
using ExpenseManager.API.Models;

namespace ExpenseManager.API.DTO
{
    /// <summary>
    /// SaveExpense Request model
    /// </summary>
    public class SaveExpenseRequest : BaseRequest
    {
        /// <summary>
        /// Expense object
        /// </summary>
        public Expense Expense { get; set; }
    }
}

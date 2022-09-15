using ExpenseManager.API.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManager.API.Controllers
{
    /// <summary>
    /// Controller for Reference Data Operations
    /// </summary>
    [ApiController]
    // [Route("[controller]")]
    public class ExpenseController : BaseController
    {
        /// <summary>
        /// IExpenseService variable
        /// </summary>
        private readonly IExpenseService _expenseService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="expenseService">ExpenseService object Injected By Dependency Injection</param>        
        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        public async Task<IActionResult> SearchExpenses()
        {

        }
    }
}

namespace ExpenseManager.API.Models
{
    /// <summary>
    /// Expense model
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Expense Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Expense CategoryEntity
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Expense Amount
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Expense Date
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Expense payment mode name
        /// </summary>
        public string PaymentModeName { get; set; }
    }
}

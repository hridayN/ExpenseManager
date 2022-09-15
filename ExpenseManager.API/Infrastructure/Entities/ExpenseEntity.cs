using ExpenseManager.API.Constants;
using ExpenseManager.API.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.API.Infrastructure.Entities
{
    /// <summary>
    /// Expense Entity class
    /// </summary>
    [Table("expense", Schema = DbConstant.ExpenseManagerSchema)]
    public class ExpenseEntity : Entity
    {
        /// <summary>
        /// ExpenseId for Expense
        /// </summary>
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Expense description
        /// </summary>
        [Column("expense_description")]
        public string ExpenseDescription { get; set; }

        /// <summary>
        /// Expense category id
        /// </summary>
        [Column("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Expense amount
        /// </summary>
        [Column("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Create Date
        /// </summary>
        [Column("date_created", TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Expense paymentmode name
        /// </summary>
        [Column("payment_mode_name")]
        public int PaymentModeName { get; set; }
    }
}

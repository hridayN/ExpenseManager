using ExpenseManager.API.Constants;
using ExpenseManager.API.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManager.API.Infrastructure.Entities
{
    /// <summary>
    /// Category Entity class
    /// </summary>
    [Table("category", Schema = DbConstant.ExpenseManagerSchema)]
    public class CategoryEntity : Entity
    {
        /// <summary>
        /// CategoryId for Category
        /// </summary>
        [Column("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Catgory name
        /// </summary>
        [Key]
        [Column("name")]
        public string Name { get; set; }
    }
}

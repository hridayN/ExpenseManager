using Microsoft.EntityFrameworkCore;
// using Newtonsoft.Json;
using ExpenseManager.API.Infrastructure.Entities;
using ExpenseManager.API.Models;

namespace ExpenseManager.API.Infrastructure
{
    /// <summary>
    /// BaseDbContext
    /// </summary>
    public class BaseDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseDbContext() : base()
        {
        }

        /// <summary>
        /// Parameterised constructor
        /// </summary>
        /// <param name="options"></param>
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Expense table
        /// </summary>
        public DbSet<ExpenseEntity> Expense { get; set; }

        /// <summary>
        /// Model creation
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<ExpenseEntity>(e =>
            {
                e.Property(p => p.)
            });*/
        }
    }
}

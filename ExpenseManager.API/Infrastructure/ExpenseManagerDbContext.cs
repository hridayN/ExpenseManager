using ExpenseManager.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManager.API.Infrastructure
{
    /// <summary>
    /// ExpenseManagerDbContext class
    /// </summary>
    public class ExpenseManagerDbContext : BaseDbContext
    {
        // private DbConnection _connection;
        private readonly string _dbType;
        private readonly string _connectionString;

        /// <summary>
        /// Constructor
        /// </summary>
        public ExpenseManagerDbContext() : base()
        {
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="configuration"></param>
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(options)
        {
            _dbType = configuration.GetValue<string>("Database:Type");
            _connectionString = configuration.GetValue<string>("Database:ConnectionString");
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="connectionString"></param>
        public ExpenseManagerDbContext(DbContextOptions<ExpenseManagerDbContext> options, IHttpContextAccessor httpContextAccessor, string connectionString) : base(options)
        {
            _dbType = "SQLServer";
            _connectionString = connectionString;
        }


        /// <summary>
        /// OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured && !string.IsNullOrWhiteSpace(_connectionString))
            {
                switch (_dbType)
                {
                    case "SQLServer":
                        optionsBuilder.UseSqlServer(_connectionString);
                        break;
                    default:
                        optionsBuilder.UseSqlServer(_connectionString);
                        break;
                }
            }
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<ExpenseEntity>(e =>
            {
                e.Property(p => p.Category).HasColumnType("jsonb");
            });
            base.OnModelCreating(modelBuilder);*/
        }
    }
}

using AutoMapper;
using ExpenseManager.API.Infrastructure.Entities;
using ExpenseManager.API.Models;

namespace ExpenseManager.API.Mapper
{
    /// <summary>
    /// Mapper class to map entity to objects and vice a versa
    /// </summary>
    public class ExpenseManagerDtoMapper : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ExpenseManagerDtoMapper()
        {
            CreateMap<ExpenseEntity, Expense>();
            CreateMap<Expense, ExpenseEntity>();

            CreateMap<CategoryEntity, Category>();
            CreateMap<Category, CategoryEntity>();
        }
    }
}

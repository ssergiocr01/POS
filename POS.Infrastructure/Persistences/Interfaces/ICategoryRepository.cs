using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Requests;
using POS.Infrastructure.Commons.Bases.Responses;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
        
    }
}

using ecommerce.Application.DTOs;
using ecommerce.Application.Featuers;

namespace ecommerce.Application.Contracts
{
    public interface ICategoryRepository
    {
        public Task<APIResponse> GetAllCategories(Register.Request request);
        public Task<APIResponse<Register.Response>> GetCategoryById(Register.Request request);
        public Task<APIResponse<Register.Response>> DeleteCategoryById(Register.Request request);
        public Task<APIResponse<Register.Response>> UpdateCategoryById(Register.Request request);
    }
}

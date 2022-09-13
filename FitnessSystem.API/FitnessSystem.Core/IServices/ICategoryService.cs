using FitnessSystem.Core.Models;

namespace FitnessSystem.Core.IServices
{
    public interface ICategoryService
    {
       public Task<bool> Add(CategoryRm model);
    }
}

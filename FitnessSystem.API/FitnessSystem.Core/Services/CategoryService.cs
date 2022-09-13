using FitnessSystem.Core.IServices;
using FitnessSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSystem.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly FitenessContext _context;

        public CategoryService(FitenessContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(CategoryRm model)
        {
            var newModel = new Category()
            {
                Name = $"Cat-{model.Name}",
                DisplayName = model.DisplayName,

            };
            await _context.Categories.AddAsync(newModel);
            _context.SaveChanges();
            return true;
        }
    }
}

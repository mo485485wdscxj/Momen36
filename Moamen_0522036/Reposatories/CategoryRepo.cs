using Microsoft.EntityFrameworkCore;
using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.InterFace;
using Moamen_0522036.Models;

namespace Moamen_0522036.Reposatories
{
    public class CategoryRepo:ICatregoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool createCtegory(CreateCategoryDto createCategoryDto)
        {
            var category = new CategoryMode
            {
                Name = createCategoryDto.Name,
            };
            _context.categories.Add(category);
            _context.SaveChanges();
            return true;    
        }

        public bool updateCtegory(UpdateCategoryDto updateCategoryDto, int id)
        {
            var category = new CategoryMode
            {
                Id = id,
                Name = updateCategoryDto.Name,
            };
            _context.categories.Update(category);
            _context.SaveChanges();
            return true;
            
        }
    }
}

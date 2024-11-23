using Moamen_0522036.Dtos.CategoryDto;

namespace Moamen_0522036.InterFace
{
    public interface ICatregoryRepo
    {
        public bool createCtegory(CreateCategoryDto createCategoryDto);
        public bool updateCtegory(UpdateCategoryDto updateCategoryDto,int id);
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.InterFace;

namespace Moamen_0522036.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatregoryRepo _repo;
        public CategoryController(ICatregoryRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult createCtegory(CreateCategoryDto createCategoryDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = _repo.createCtegory(createCategoryDto);
            if(res)return BadRequest(res);
            return Ok(res);

        }
        [HttpPut("{id}")]
        public IActionResult updateCtegory(UpdateCategoryDto updateCategoryDto, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var category = _repo.updateCtegory(updateCategoryDto,id);
            if(!category) return BadRequest();
            return Ok(category);

        }
    }
}

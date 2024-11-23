using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.InterFace;

namespace Moamen_0522036.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationalRepo _repo;
        public NationalityController(INationalRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Add(CreateNationakityDto createNationakityDto)
        {
            var nationality = _repo.Add(createNationakityDto);
            if(nationality)
                return Ok(nationality);
            return NotFound();


        }
        [HttpDelete("{id}")]
        public IActionResult delet(int id)
        {
            var delet = _repo.delet(id);
            if(delet)
                return Ok();
            return NotFound();
        }
    }
}

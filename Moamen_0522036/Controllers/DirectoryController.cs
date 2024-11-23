using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.InterFace;

namespace Moamen_0522036.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectoryRepo _repo;
        public DirectoryController(IDirectoryRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult CreateDirectoryDto(CreateDirectoryDto CreateDirectoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var directory = _repo.CreateDirectoryDto(CreateDirectoryDto);
            if (directory) return Ok(directory);
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult updateDirectory(UpdateDirectoryDto UpdateDirectoryDto, int id)
        {
            var directory = _repo.updateDirectory(UpdateDirectoryDto, id);
            if (directory) return Ok(directory);
            return NotFound();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteDirectory(int id)
        {
            var directory = _repo.deleteDirectory(id);
            if(directory)return Ok(directory);
            return NotFound();
        }
    }
}

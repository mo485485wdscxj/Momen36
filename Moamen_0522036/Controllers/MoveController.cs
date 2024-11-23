using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moamen_0522036.Dtos.MoveDto;
using Moamen_0522036.InterFace;

namespace Moamen_0522036.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMoveRpo _repo;
        public MoveController(IMoveRpo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }
        [HttpPost]
        public IActionResult Add(CreateMoveDto createMoveDto)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            var res = _repo.Add(createMoveDto);
            if(res)
            {
                return Created();
            }
            return BadRequest();

        }
    }
}

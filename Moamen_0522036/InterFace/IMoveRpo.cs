using Moamen_0522036.Dtos.MoveDto;

namespace Moamen_0522036.InterFace
{
    public interface IMoveRpo
    {
        public ICollection <MoveDto> GetAll();
        public MoveDto? GetById(int id);
        public bool Add(CreateMoveDto createMoveDto);
    }
}

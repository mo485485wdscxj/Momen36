using Moamen_0522036.Dtos.NationalDto;

namespace Moamen_0522036.InterFace
{
    public interface INationalRepo
    {
        public bool Add(CreateNationakityDto createNationakityDto);
        public bool delet (int id);
    }
}

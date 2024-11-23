using Moamen_0522036.Dtos.DirectoryDto;

namespace Moamen_0522036.InterFace
{
    public interface IDirectoryRepo
    {
        public bool CreateDirectoryDto(CreateDirectoryDto CreateDirectoryDto);
        public bool updateDirectory(UpdateDirectoryDto UpdateDirectoryDto,int id);
        public bool deleteDirectory(int id);

    }
}

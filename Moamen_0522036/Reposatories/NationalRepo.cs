using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.InterFace;
using Moamen_0522036.Models;

namespace Moamen_0522036.Reposatories
{
    public class NationalRepo:INationalRepo
    {
        private readonly AppDbContext _context;
        public NationalRepo (AppDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateNationakityDto createNationakityDto)
        {
            var nationality = new NationalityModel
            {
                Name = createNationakityDto.Name,
            };
            _context.nationalities.Add(nationality);
            _context.Add(nationality);
            return true;
        }

        public bool delet(int id)
        {
            var delet = _context.nationalities.Find(id);
            if (delet == null) { return false; }
            _context.Remove(delet);
            _context.SaveChanges();
            return true;
        }
    }
}

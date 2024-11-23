using Microsoft.EntityFrameworkCore;
using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.Dtos.MoveDto;
using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.InterFace;
using Moamen_0522036.Models;

namespace Moamen_0522036.Reposatories
{
    public class MoviesRpo:IMoveRpo
    {
        private readonly AppDbContext _context;
        public MoviesRpo (AppDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateMoveDto createMoveDto)
        {
            var move = new MoviesModel
            {
                 Title = createMoveDto.Title,
                 ReleaseYear = createMoveDto.ReleaseYear,
                 categories=createMoveDto.Categorydto
                .Select(x => new CategoryMode
                {
                    Name = x.Name,
                }).ToList(),
                Directors=createMoveDto.Directors!.Select(x=>new 
                DirectorModel {
                Contact = x.Contact,
                Email = x.Email,
                Name = x.Name,
                Nationality= new NationalityModel {
                    Name = x.Name,
                }
                }).ToList(),
            };
            _context.movies.Add(move);
            _context.SaveChanges();
            return true;
        }

        public ICollection<MoveDto> GetAll()
        {
            var movies = _context.movies
                 .Include(x => x.Directors)
                 .ThenInclude(x => x.Nationality)
                 .Include(x => x.categories)
                 .Select(x => new MoveDto
                 {
                     ReleaseYear=x.ReleaseYear,
                     Title = x.Title,
                     categories = x.categories!.Select(x => new CategoryDtos
                     {
                         Name = x.Name,
                     }).ToList(),
                     Directors = x.Directors!.Select(x => new DirectoryDtos
                     {
                         Name = x.Name,
                         Contact = x.Contact,
                         Email = x.Email,
                         Nationality = new NationalityDto
                         {
                             Name = x.Nationality!.Name,
                         }
                     }).ToList(),

                 }).ToList();
            return movies;
        }


        public MoveDto? GetById(int id)
        {
            var move = _context.movies
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.categories)
                .FirstOrDefault(X => X.Id == id);
            if (move == null) return null;
            var Move = new MoveDto
            {
                ReleaseYear = move.ReleaseYear,
                Title = move.Title,
                categories = move.categories!.Select(x => new CategoryDtos
                {
                    Name = x.Name,

                }).ToList(),
                Directors = move.Directors!.Select(x => new DirectoryDtos
                {
                    Name = x.Name,
                    Contact = x.Contact,
                    Email = x.Email,
                    Nationality = new NationalityDto
                    {
                        Name = x.Nationality.Name,
                    }
                }).ToList(),
            };
            return Move;
 
        }
    }
}

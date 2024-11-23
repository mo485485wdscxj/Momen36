using Microsoft.EntityFrameworkCore;
using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.InterFace;
using Moamen_0522036.Models;
using System.Collections;

namespace Moamen_0522036.Reposatories
{
    public class DirectoryRepo : IDirectoryRepo
    {
        private readonly AppDbContext _context;
        public DirectoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool CreateDirectoryDto(CreateDirectoryDto CreateDirectoryDto)
        {

            var Directory = new DirectorModel
            {
                Contact = CreateDirectoryDto.Contact,
                Email = CreateDirectoryDto.Email,
                Name = CreateDirectoryDto.Name,
                Nationality = new NationalityModel
                {
                    Name = CreateDirectoryDto.Nationality.Name
                }
            };
            _context.Add(Directory);
            _context.SaveChanges();
            return true;
        }

        public bool deleteDirectory(int id)
        {
            var directory = _context.directors.First(d => d.Id == id);
            if (directory == null) return false;
            _context.Remove(directory);
            _context.SaveChanges();
            return true;
        }

        public bool updateDirectory(UpdateDirectoryDto updateDirectoryDto, int id)
        {
            var directory = _context.directors.Include(x => x.Movies)
                .ThenInclude(x => x.categories)
                .Include(x => x.Nationality)
                .FirstOrDefault(x => x.Id == id);
            if (directory == null) return false;

            directory.Contact = updateDirectoryDto.Contact;
            directory.Email = updateDirectoryDto.Email;
            directory.Name = updateDirectoryDto.Name;
            directory.Nationality = new NationalityModel
            {
                Id = updateDirectoryDto.updateNationalitydto.Id,
                Name = updateDirectoryDto.updateNationalitydto.Name,
            };

            directory.Movies = updateDirectoryDto.Movies.Select(x => new MoviesModel
            {
                Id = x.Id,
                ReleaseYear = x.ReleaseYear,
                Title = x.Title,
                categories = x.categories.Select(x => new CategoryMode
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList(),
            }).ToList();

            _context.Update(directory);
            _context.SaveChanges();
            return true;
        }
    }
}

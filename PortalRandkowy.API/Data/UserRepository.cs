using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalRandkowy.API.Helpers;
using PortalRandkowy.API.Models;

namespace PortalRandkowy.API.Data
{
    public class UserRepository : GenericRepository, IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = _context.Users.Include(p => p.Photos).OrderByDescending(u => u.LastActive).AsQueryable();

            users = users.Where(u => u.Id != userParams.UserId);
            users = users.Where(u => u.Gender == userParams.Gender);

            if (userParams.MinAge != 18 || userParams.MaxAge != 100)
            {
                var minDate = DateTime.Today.AddYears(-userParams.MaxAge -1);
                var maxDate = DateTime.Today.AddYears(-userParams.MinAge);
                users = users.Where(u => u.DateOfBirth >= minDate && u.DateOfBirth <= maxDate);
            }

            if (userParams.ZodiacSign != "Wszystkie")
                users = users.Where(u => u.ZodiacSign == userParams.ZodiacSign);

            if (!string.IsNullOrEmpty(userParams.OrderBy))
            {
                switch (userParams.OrderBy)
                {
                    case "created":
                        users = users.OrderByDescending(u => u.Created);
                        break;
                    default:
                        users = users.OrderByDescending(u => u.LastActive);
                        break;
                }
            }

            return await PagedList<User>.CreateListAsync(users, userParams.PageNumber, userParams.PageSize);
        }
       
        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            return photo;
        }

        public async Task<Photo> GetMainPhotoForUser(int userId)
        {
            return await _context.Photos.Where(u => u.UserId == userId).FirstOrDefaultAsync(p => p.IsMain);
        }
    }
}
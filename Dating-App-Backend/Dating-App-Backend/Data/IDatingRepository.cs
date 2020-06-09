
using System.Collections.Generic;
using System.Threading.Tasks;
using Dating_App_Backend.Helpers;
using Dating_App_Backend.Models;

namespace Dating_App_Backend.Data
{
    public interface IDatingRepository
    {

        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<PagedList<User>> GetUsers(UserParams userParams);

        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);

        Task<Like> GetLike(int userId, int recipientId);


    }
}

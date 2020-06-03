
using System.Collections.Generic;
using System.Threading.Tasks;
using Dating_App_Backend.Models;

namespace Dating_App_Backend.Data
{
    public interface IDatingRepository
    {

        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);


    }
}

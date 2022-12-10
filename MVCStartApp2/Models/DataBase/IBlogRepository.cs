using System.Threading.Tasks;

namespace MVCStartApp2.Models.DataBase
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}

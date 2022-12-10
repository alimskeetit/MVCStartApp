using System.Threading.Tasks;

namespace MVCStartApp2.Models.DataBase
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequests();
    }
}

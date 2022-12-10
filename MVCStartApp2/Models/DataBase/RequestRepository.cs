using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MVCStartApp2.Models.DataBase
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BlogContext _context;

        public RequestRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task AddRequest(Request request)
        {
            request.Id = Guid.NewGuid();
            request.Date = DateTime.Now;

            await _context.Requests.AddAsync(request);

            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetRequests()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}

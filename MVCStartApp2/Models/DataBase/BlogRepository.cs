using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCStartApp2.Models.DataBase
{
    public class BlogRepository: IBlogRepository
    {
        //ссылка на контекст
        private readonly BlogContext _context;

        //конструктор
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            user.JoinDate = DateTime.Now;
            user.Id = Guid.NewGuid();

            //Добавление пользователя
            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
                await _context.Users.AddAsync(user);

            //сохранение изменений
            await _context.SaveChangesAsync();
        }

        public async Task<User[]> GetUsers()
        {
            //Получим всех активных пользователей
            return await _context.Users.ToArrayAsync();
        }
    }
}

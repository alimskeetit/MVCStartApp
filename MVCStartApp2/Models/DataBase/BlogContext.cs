using Microsoft.EntityFrameworkCore;

namespace MVCStartApp2.Models.DataBase
{
    /// <summary>
    /// Класс контекста, предоставляющий доступ к сущностям базы данных
    /// </summary>
    public sealed class BlogContext: DbContext
    {
        //Ссылка на таблицу Users
        public DbSet<User> Users { get; set; }

        //Ссылка на таблицу UsersPosts
        public DbSet<UserPost> UsersPosts { get; set; }

        //Ссылка на таблицу Requests
        public DbSet<Request> Requests { get; set; }

        //Логика взаимодействия с таблицами в БД
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}

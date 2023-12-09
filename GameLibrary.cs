namespace GameLibrary
{
    public class Class1 : DbContext
    {
        internal object Database;

        public DbSet<Game> Games { get; set; }
        public object Options { get; }

        // Конструктор, що приймає параметром опції зв'язку з базою даних
        public Class1(DbContextOptions<Class1> options) : base(options)
        {
        }

        public Class1(object options)
        {
            Options = options;
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContextOptions<T>
    {
    }

    public class DbSet<T>
    {
        internal void Add(Game myGame)
        {
            throw new NotImplementedException();
        }
    }

using GameLibrary;

namespace GameConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Встановіть під'єднання до бази даних
            var options = new DbContextOptionsBuilder<Class1>()
                .UseSqlServer("your_connection_string_here")
               

            // Створіть екземпляр DbContext
            using (Class1 dbContext = new Class1(options))
            {
                // Створіть базу даних, якщо вона ще не існує
                object value = dbContext.Database.EnsureCreated();

                // Створіть об'єкт гри
                var myGame = new Game("Cyberpunk 2077", "CD Projekt", "Action RPG", new DateTime(2020, 12, 10));

                // Додайте гру до DbSet та збережіть зміни в базі даних
                dbContext.Games.Add(myGame);
                dbContext.SaveChanges();
            }

            Console.WriteLine("Гра успішно додана до бази даних.");

            // Зупиніть консоль, щоб результат можна було переглянути
            Console.ReadLine();
        }
    }

    internal class DbContextOptionsBuilder<T>
    {
        public DbContextOptionsBuilder()
        {
        }

        internal object UseSqlServer(string v)
        {
            throw new NotImplementedException();
        }
    }
}

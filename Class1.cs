using System.Diagnostics;

namespace GameLibrary
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Class1 : DbContext
    {
        public DbSet<Game> Games { get; set; }

        // Конструктор, що приймає параметром опції зв'язку з базою даних
        public Class1(DbContextOptions<Class1> options) : base(options)
        {
        }

        // Метод для створення бази даних та внесення даних
        public void InitializeDatabase()
        {
            Database.EnsureCreated();

            if (Games.Any())
            {
                return;
            }
            // Додаємо кілька записів
            Games.Add(new Game("Cyberpunk 2077", "CD Projekt", "Action RPG", new DateTime(2020, 12, 10)));
            Games.Add(new Game("The Witcher 3: Wild Hunt", "CD Projekt", "Action RPG", new DateTime(2015, 5, 19)));
            Games.Add(new Game("Assassin's Creed Valhalla", "Ubisoft", "Action RPG", new DateTime(2020, 11, 10)));

            SaveChanges();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

using System;
using GameLibrary; // Додайте посилання на вашу dll

class Program
{
    static void Main()
    {
        // екземпляр класу Game
        Game myGame = new Game("Cyberpunk 2077", "CD Projekt", "Action RPG", new DateTime(2020, 12, 10));

        // Вивід інформації про гру
        myGame.DisplayInfo();

        // Зупинка консолі, щоб результат можна було переглянути
        Console.ReadLine();
    }
}

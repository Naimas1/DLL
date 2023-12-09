using System;

namespace GameLibrary
{
    public class Game
    {
        // Властивості для зберігання інформації про гру
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        // Конструктор класу
        public Game(string title, string studio, string genre, DateTime releaseDate)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

        // Метод для виведення інформації про гру
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва гри: {Title}");
            Console.WriteLine($"Студія: {Studio}");
            Console.WriteLine($"Стиль гри: {Genre}");
            Console.WriteLine($"Дата релізу: {ReleaseDate.ToShortDateString()}");



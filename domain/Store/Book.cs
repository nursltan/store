using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Book //Класс для хранения книг
    {
        public int Id { get; }

        public string Isbn { get; }

        public string Author { get; }
        public string Title { get; } //только для чтения

        public Book(int id,string isbn,string author, string title) //конструктор
        {
            Id = id;
            Isbn = isbn;
            Author = author;
            Title = title;
        }

        internal static bool IsIsbn(string s)
        {
            if (s == null)
                return false;
            s = s.Replace("-", "") // Дефисы и пробелы заменяем 
                .Replace(" ", "") // на пустые строки
                .ToUpper(); // приводим к верхнему регистру

            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}

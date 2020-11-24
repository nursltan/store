using System;

namespace Store
{
    public class Book //Класс для хранения книг
    {
        public int Id { get; }
        public string Title { get; } //только для чтения

        public Book(int id,string title) //конструктор
        {
            Id = id;
            Title = title;
        }
    }
}

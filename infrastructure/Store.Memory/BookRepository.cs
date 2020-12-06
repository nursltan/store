using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 0321751043","D. Knuth", "Art of Programming",
                "Finally, after a wait of more than thirty-five years, the first part of Volume 4 is at last ready for publication.",
                7.19m),
            new Book(2,"ISBN 0201485672","M. Fowler", "Refactoring",
                "Whenever you read [Refactoring], it’s time to read it again. And if you haven’t read it yet, please do before writing another line of code.",
                12.45m),
            new Book(3, "ISBN 0131101633","B. Kernighan, D. Ritchie","C Programming Language",
                "Known as the bible of C, this classic bestseller introduces the C programming language and illustrates algorithms, data structures, and programming techniques.", 
                14.98m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    ||  book.Title.Contains(query))
                .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }

        public Book[] GetByIds(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books
                             join bookId in bookIds on book.Id equals bookId
                             select book;

            return foundBooks.ToArray();
        }
    }
}


using System.Collections.Generic;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);

        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);
        Book GetById(int id);
        Book[] GetByIds(IEnumerable<int> bookIds);
    }
}

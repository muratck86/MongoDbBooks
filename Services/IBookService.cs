using MongoDbBooks.Models;
using System.Collections.Generic;

namespace MongoDbBooks.Services
{
    public interface IBookService
    {
        List<Book> Get();
        Book Get(string id);
        Book Create(Book book);
        void Update(string id, Book bookIn);
        void Remove(string id);
        void Remove(Book book);
    }
}

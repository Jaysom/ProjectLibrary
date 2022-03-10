using ProjectLibrary.Classes;
using ProjectLibrary.Data;
using ProjectLibrary.Services.Interfaces;

namespace ProjectLibrary.Services.Implementations
{
    public class LibraryService : ILibraryService
    {
        private List<Book> Books { get; set; }

        public LibraryService()
        {
            Books = new Library().Books;
        }

        public List<Item> GetItemCollection()
        {
            return Books.Select(b => new Item() { Id = b.Id, Price = b.Price, Related = b.Related, Title = b.Title }).ToList();
        }

        public Book GetBookById(int id)
        {
            return Books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> UpdateBook(Book book)
        {
            var index = Books.FindIndex(a => a.Id == book.Id);
            Books[index] = book;

            return Books;
        }

        public List<Book> DeleteBook(int id)
        {
            Books.Remove(GetBookById(id));

            return Books;
        }

    }
}

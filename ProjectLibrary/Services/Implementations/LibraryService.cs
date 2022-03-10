using ProjectLibrary.Classes;
using ProjectLibrary.Data;
using ProjectLibrary.Services.Interfaces;

namespace ProjectLibrary.Services.Implementations
{
    public class LibraryService : ILibraryService
    {
        public List<Item> GetItemCollection()
        {
            var books = new Library().Books;
          
            return books.Select(b => new Item() { Id = b.Id, Price = b.Price, Related = b.Related, Title = b.Title }).ToList();
        }

        public Book GetBookById(int id)
        {
            var books = new Library().Books;

            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}

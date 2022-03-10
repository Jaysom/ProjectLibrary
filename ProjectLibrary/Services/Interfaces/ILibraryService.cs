using ProjectLibrary.Classes;

namespace ProjectLibrary.Services.Interfaces
{
    public interface ILibraryService
    {
        List<Item> GetItemCollection();

        Book GetBookById(int id);

        List<Book> UpdateBook(Book book);

        List<Book> DeleteBook(int id);
    }
}

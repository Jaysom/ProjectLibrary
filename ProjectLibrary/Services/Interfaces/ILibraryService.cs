using ProjectLibrary.Classes;

namespace ProjectLibrary.Services.Interfaces
{
    public interface ILibraryService
    {
        List<Item> GetItemCollection();

        Book GetBookById(int id);

        Task UpdateBook(Book book);

        Task DeleteBook(int id);
    }
}

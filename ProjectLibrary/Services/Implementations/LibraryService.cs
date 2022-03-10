using ProjectLibrary.Classes;
using ProjectLibrary.Data;
using ProjectLibrary.Services.Interfaces;

namespace ProjectLibrary.Services.Implementations
{
    public class LibraryService : ILibraryService
    {
        private readonly ApplicationDBContext _dbContext;

        public LibraryService(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public List<Item> GetItemCollection()
        {
            return _dbContext.Books.Select(b => new Item() { Id = b.Id, Price = b.Price, Related = new int[] { b.Related }, Title = b.Title, }).ToList();
        }

        public Book GetBookById(int id)
        {
            try
            {
                return _dbContext.Books.FirstOrDefault(b => b.Id == id);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public async Task UpdateBook(Book book)
        {
            try
            {
                _dbContext.Update(book);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task DeleteBook(int id)
        {
            try
            {
                _dbContext.Books.Remove(GetBookById(id));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}

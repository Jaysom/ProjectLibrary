using Microsoft.AspNetCore.Mvc;
using ProjectLibrary.Classes;
using ProjectLibrary.Services.Interfaces;

namespace ProjectLibrary.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class LibraryController : ControllerBase
    {
        private ILibraryService _libraryService;
        private ILogger<LibraryController> _logger;

        public LibraryController(ILibraryService libraryService, ILogger<LibraryController> logger)
        {
            _libraryService = libraryService;
            _logger = logger;
        }

        [HttpGet("items")]
        public List<Item> GetAllItems() => _libraryService.GetItemCollection();


        [HttpGet("book/{id}")]
        public Book GetBookByItemId(int id)
        {
            try
            {
                if (_libraryService.GetBookById(id) == null)
                {
                    _logger.LogInformation($"No book was found with the Id: {id}");
                }
                
                return _libraryService.GetBookById(id);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);

                return null;
            }
        }



        [HttpPut("book/{book}")]
        public async Task UpdateBook(Book book)
        {
            try
            {
                await _libraryService.UpdateBook(book);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
            }
            
        }


        [HttpPost("delete/{id}")]
        public void DeleteBook(int id)
        {
            try
            {
                _libraryService.DeleteBook(id);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
            }
        } 
    }
}
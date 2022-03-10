using Microsoft.AspNetCore.Mvc;
using ProjectLibrary.Classes;
using ProjectLibrary.Services.Interfaces;

namespace ProjectLibrary.Controllers
{
    [Route("api/library/[action]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet(Name = "/items")]
        public List<Item> GetAllItems() => _libraryService.GetItemCollection();

        [HttpGet(Name = "/book/{id}")]
        public Book GetBookByItemId(int id) => _libraryService.GetBookById(id);
    }
}
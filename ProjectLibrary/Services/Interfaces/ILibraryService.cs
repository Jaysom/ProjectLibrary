﻿using ProjectLibrary.Classes;

namespace ProjectLibrary.Services.Interfaces
{
    public interface ILibraryService
    {
        List<Item> GetItemCollection();

        Book GetBookById(int id);
    }
}
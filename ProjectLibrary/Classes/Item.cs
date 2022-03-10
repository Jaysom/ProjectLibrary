using Microsoft.AspNetCore.Mvc;

namespace ProjectLibrary.Classes
{
    public class Item
    {
        public int Id { get; set; }
        public string Link => $"/api/v{ApiVersion.Neutral}/item/{Id}";
        public string Title { get; set; }
        public double Price { get; set; }
        public int[] Related { get; set; }
    }
}
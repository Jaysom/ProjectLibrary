namespace ProjectLibrary.Classes
{
    public class Item
    {
        public int Id { get; set; }
        public string Link => $"/api/v1/items/{Id}";
        public string Title { get; set; }
        public double Price { get; set; }
        public int[] Related { get; set; }
    }
}
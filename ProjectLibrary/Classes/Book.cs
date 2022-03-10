namespace ProjectLibrary.Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string[] Terms { get; set; }
        public int[] Related { get; set; }
    }
}
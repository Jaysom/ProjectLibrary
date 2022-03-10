using ProjectLibrary.Classes;

namespace ProjectLibrary.Data
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 8,
                    Title = "A Dance with Dragons",
                    Author = "George R.R. Martin",
                    Image = "http://lh6.ggpht.com/-moHp1rtECqI/TnUX5Tx_t_I/AAAAAAAALx0/B6Xd0x2nc3w/s1600-h/George-R.R.-Martin-A-Dance-with-Dragons%25255B2%25255D.jpg",
                    Price = 19.01,
                    Terms =  "Sci-fi , A Song of Ice and Fire, dragons",
                    Related = 23 
                },
                new Book()
                {
                    Id = 42,
                    Title = "The Hitch-hikers Guide to the Galaxy",
                    Author = "Douglas Adams",
                    Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/3454/9780345453747.jpg",
                    Price = 5.0,
                    Terms = "Sci-fi, Comedy, Meaning of Life"
                },
                new Book()
                {
                    Id = 23,
                    Title = "A Game of Thrones",
                    Author = "George R.R. Martin",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51IHAPK5fsL.jpg",
                    Price = 3.29,
                    Terms = "Sci-fi, A Song of Ice and Fire, Epic, Best-Seller, Dragons",
                    Related = 8 
                },
                new Book()
                {
                    Id = 2001,
                    Title = "2001: A Space Odyssey",
                    Author = "Arthur C. Clark",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61lJNV04+wL.jpg",
                    Price = 2.0,
                    Terms = "Sci-fi, Aliens"
                }
            };
        }
    }
}

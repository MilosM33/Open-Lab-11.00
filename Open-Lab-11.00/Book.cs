using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Book
    {
        /// <summary>
        /// Return list of available categories.
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        public Book()
        {
            this.title = "-1";
            this.author = "-1";
            this.pages = -1;
            this.category = "-1";
            this.releaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.author = "-1";
            this.pages = pages;
            this.category = "-1";
            this.releaseDate = -1;
        }

        public Book(string title, int pages, string author, string category, int releaseDate)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.category = category;
            this.releaseDate = releaseDate;
        }

        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        /// <summary>
        /// Return title of book.
        /// </summary>
        public string Title
        {
            get => title;
            set => title = value;
        }
        /// <summary>
        /// Return number of pages.
        /// </summary>
        public int Pages
        {
            get => pages;
            set => pages = (value < 0 ? -1 : value);
        }

        /// <summary>
        /// Return category of book.
        /// </summary>
        public string Category
        {
            set => category = value;
        }
        /// <summary>
        /// Return author name.
        /// </summary>
        public string Author
        {
            get => author;
            set => author = value;
        }
        /// <summary>
        /// Return release date
        /// </summary>
        public int ReleaseDate
        {
            get => releaseDate;
            set => releaseDate = (value < 1450 || value > 2021 ? -1 : value);
        }
        public void GetInfo() => Console.WriteLine($"{title} is very original book long about {pages} by {author} released at {releaseDate}. Category = {category}");

    }
}

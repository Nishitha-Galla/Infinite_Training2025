using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    class Books
    {
        public string BookName;
        public string AuthorName;
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine("Book: " + BookName  + " , Author: - " + AuthorName);
        }
    }
    class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
    class Program3
    {
        static void Main()
        {
            BookShelf bs = new BookShelf();
            bs[0] = new Books("Bagavadgita", "Vyasa");
            bs[1] = new Books("Ramanayam", "Valmiki");
            bs[2] = new Books("m", "Ram");
            bs[3] = new Books("n", "Sita");
            bs[4] = new Books("mn", "Hanuman");

            Console.WriteLine("Books in book shelf are: \n");
            for(int i=0; i<5; i++)
            {
                bs[i].Display();
            }
            Console.ReadLine();

        }

    }
    
}

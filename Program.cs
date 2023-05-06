using System;

namespace LibraryPractice
{
    class Program
    {
        static Book[] books = new Book[10];
        static string[] bookNames = {"To Kill a Mockingbird", "1984", "King James Bible", "All Tomrrows", "No Country for Old Men"};
        static public Random rd;

        static void Main(string[] args)
        {
            rd = new Random();

            Console.WriteLine("Books:");

            for (int i = 0; i < books.Length; i++)
            {
                Book b = new Book();
                books[i] = b;
                NameGen(b);
                b.Index = i;
                Console.WriteLine(b.name + ", " + b.Index);
            }
        }

        static void NameGen(Book book)
        {
            int nameIndex = rd.Next(0, bookNames.Length);
            book.name = bookNames[nameIndex];
        }
    }

    class Book
    {
        public string name = "NoName";

        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
    }
}

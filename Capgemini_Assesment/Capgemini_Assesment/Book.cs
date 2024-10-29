using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class Book
    {
        public static void Main(string[] args)
        {
            IList<Book> book = new List<Book>();
            BookImplementaion imp = new BookImplementaion();
            Console.WriteLine(imp.NameOfAllBooks(book));
            Console.WriteLine(imp.PriceOfAllBooks(book));
            Console.WriteLine(imp.SumPriceOfAllBooks(book));
            string s = Console.ReadLine();
            s = s.ToLower();
           imp.Find(book, s);
        }
        public string Name { get; set; }
        public int Price { get; set; }

        public Book(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class BookImplementaion
    {
        public string NameOfAllBooks(IList<Book> book)
        {
            book.Add(new Book("Subtle"));
            book.Add(new Book("Sapiens"));
            book.Add(new Book("The_Wings_Of_Fire"));
            book.Add(new Book("UnpostedLetters"));
            book.Add(new Book("secret"));
            Console.WriteLine();
            foreach (Book res in book)
            {
                Console.Write(res.Name + " ");
            }

            return "";
        }
        public string PriceOfAllBooks(IList<Book> books)
        {
            books[0].Price = 1100;
            books[1].Price = 1200;
            books[2].Price = 1300;
            books[3].Price = 1400;
            books[4].Price = 1500;
            Console.WriteLine();
            foreach (Book res in books)
            {
                Console.Write(res.Price + " ");
            }

            return "";
        }
        public int SumPriceOfAllBooks(IList<Book> books)
        {
            int sum = 0;
            Console.WriteLine();
            foreach (Book book in books)
            {
                sum += book.Price;
            }

            return sum;
        }
        public int Find(IList<Book> books, string s)
        {
            bool b = books.Any(book => book.Name.ToLower().Contains(s));
            if (b == false)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Name == s)
                        Console.WriteLine(i);
                }
            }
            return 0;
        }
    }
}
       // Console.WriteLine ("Try programiz.pro");


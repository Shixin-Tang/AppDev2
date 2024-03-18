using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();

            string filePath = "books.csv";

            while (true)
            {
                Console.WriteLine("Enter book name (leave empty and press enter to finish):");
                string name = Console.ReadLine();

                // If the user inputs an empty name, ends the reading process
                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.WriteLine("Enter number of pages:");
                int pages = int.Parse(Console.ReadLine()); 

                Console.WriteLine("Enter publication year:");
                int publicationYear = int.Parse(Console.ReadLine());

                Book book = new Book(name, pages, publicationYear);
                books.Add(book);

                Console.WriteLine("Book added successfully.\n");
            }

            SaveBooksToCsv(books, filePath);
            Console.WriteLine("Write books into books.csv file.\n");

            List<Book> loadedBooks = LoadBooksFromCsv(filePath);
            Console.WriteLine("\nBooks loaded from books.csv file:");
            foreach (var book in loadedBooks)
            {
                Console.WriteLine(book.ToCsvString());
            }

            while (true)
            {
                Console.WriteLine("\nWhat information will be printed(everything or name or any other to quit:");
                string name = Console.ReadLine();

                // If the user input everything, prints all book information
                if (name == "everything")
                {
                    foreach (Book book in loadedBooks)
                    {
                        Console.WriteLine(book);
                    }
                }

                // If the user input name, prints only the book names
                else if (name == "name")
                {
                    foreach (Book book in loadedBooks)
                    {
                        Console.WriteLine("Book name: " + book.name);
                    }
                }

                else 
                {
                    break;
                }
            }
        }

        private static void SaveBooksToCsv(List<Book> books, string filePath)
        {
            List<string> lines = new List<string>();
            foreach (Book book in books)
            {
                lines.Add(book.ToCsvString());
            }
            System.IO.File.WriteAllLines(filePath, lines);
        }

        private static List<Book> LoadBooksFromCsv(string filePath)
        {
            List<Book> books = new List<Book>();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                books.Add(Book.FromCsvString(line));
            }
            return books;
        }
    }
}

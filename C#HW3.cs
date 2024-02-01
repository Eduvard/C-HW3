using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    
    public Book(string title, string author, string category, int year, double price)
    {
        Title = title;
        Author = author;
        Category = category;
        Year = year;
        Price = price;
    }
}


static class LibraryManager
{
    private static List<Book> books = new List<Book>();

    
    public static void AddBook(Book book)
    {
        books.Add(book);
    }

    
    public static void RemoveBook(string title)
    {
        books.RemoveAll(b => b.Title == title);
    }

    
    public static void ListAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Year: {book.Year}, Price: {book.Price}");
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List All Books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    LibraryManager.AddBook(new Book(title, author, category, year, price));
                    break;

                case 2:
                    Console.Write("Enter Title of Book to Remove: ");
                    string titleToRemove = Console.ReadLine();
                    LibraryManager.RemoveBook(titleToRemove);
                    break;

                case 3:
                    Console.WriteLine("\nList of All Books:");
                    LibraryManager.ListAllBooks();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


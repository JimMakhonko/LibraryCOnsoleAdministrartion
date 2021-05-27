using System;

namespace LibAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = { { "Poe","Rowling","Glukhovsky"},
            {"Blok","Remark", "Ekziuperi"},
            {"Dostoevsky","King","Lavkraft" } };

            while (isOpen)
            {
                Console.WriteLine("Library");
                Console.WriteLine("1 - Get informtion about the book by index.\n2 - Find the book by author.\n3 - Print the list of the books.\n4 - Close the program.");
                Console.Write("Type the command: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int columns;
                        Console.Write("Enter the number of the shelf: ");
                        rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Enter the book index: ");
                        columns = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine($"\nThis book - {books[rows, columns]}");
                        break;
                    case 2:
                        string author;
                        bool authorFound = false;
                        Console.Write("Enter the author: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Author - {books[i, j]} is located  on the shelf {i + 1} | and it's order number is {j + 1}");
                                    authorFound = true;
                                }
                            }
                        }
                        if (authorFound == false)
                        {
                            Console.WriteLine("There's no such author!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nWhole list of authors: \n");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        isOpen = false;
                        Console.WriteLine("Good Bye!");
                        break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

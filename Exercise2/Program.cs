using Exercise2;

public class Program
{
    public static void Main()
    {
        int mainChoice = 0;
        DocumentManager documentManager = new DocumentManager();
        do
        {
            DisplayMenu();
            int.TryParse(Console.ReadLine(), out mainChoice);
            switch (mainChoice)
            {
                case 1:
                    AddDocument(documentManager);
                    break;
                case 2: 
                    Console.WriteLine("remove a one");
                    break;
                case 3:
                    Console.WriteLine("display all");
                    break;
                case 4:
                    Console.WriteLine("search by type");
                    break;
                case 5:
                    Console.WriteLine("Exit the program!!!");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please select again!");
                    break;
            }
            
        } while (mainChoice != 5);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Document Management System");
        Console.WriteLine("1. Add a new document.");
        Console.WriteLine("2. Remove the document by id");
        Console.WriteLine("3. Display all documents.");
        Console.WriteLine("4. Search the document by document type");
        Console.WriteLine("5. Exit the program");
        Console.WriteLine("-------------------------------------");
        Console.Write(">> ");
    }

    static void AddDocument(DocumentManager documentManager)
    {
        DisplaySubMenu1();
        int choice1 = 0;
        int.TryParse(Console.ReadLine(), out choice1);
        switch(choice1)
        {
            case 1:
                documentManager.AddDocument(BookFactory());
                break;
            case 2:
                documentManager.AddDocument(MagazineFactory());
                break;
            case 3:
                Console.WriteLine("newspaper");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }

    static void DisplaySubMenu1()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1. Add a book.");
        Console.WriteLine("2. Add a magazine.");
        Console.WriteLine("3. Add a newspaper.");
        Console.WriteLine("-------------------------------------");
        Console.Write(">> ");
    }
    static Book BookFactory()
    {
        int id, numOfCopies, numOfPages;
        string publisher, author;
        Console.WriteLine("Enter the input");
        Console.Write("Id: ");
        bool validId = int.TryParse(Console.ReadLine(), out id);
        Console.Write("Publisher: ");
        publisher = Console.ReadLine();
        Console.Write("Number of copies: ");
        bool validNumOfCopies = int.TryParse(Console.ReadLine(), out numOfCopies);
        Console.Write("Author: ");
        author = Console.ReadLine();
        Console.Write("Number of pages: ");
        bool validNumOfPages = int.TryParse(Console.ReadLine(), out numOfPages);
        if (validId && validNumOfCopies && validNumOfPages)
        {
            Console.WriteLine("Successfully created!!!");
            return new Book(id, publisher, numOfCopies, author, numOfPages);
        } else
        {
            Console.WriteLine("Cannot create document since invalid input!");
            return null;
        }
    }

    static Magazine MagazineFactory()
    {
        int id, numOfCopies, numOfPublish, month;
        string publisher, ;
        Console.WriteLine("Enter the input");
        Console.Write("Id: ");
        bool validId = int.TryParse(Console.ReadLine(), out id);
        Console.Write("Publisher: ");
        publisher = Console.ReadLine();
        Console.Write("Number of copies: ");
        bool validNumOfCopies = int.TryParse(Console.ReadLine(), out numOfCopies);
        Console.Write("Number of copies: ");
        bool validNumOfPublish = int.TryParse(Console.ReadLine(), out numOfPublish);
        Console.Write("Number of pages: ");
        bool validMonth = int.TryParse(Console.ReadLine(), out month);
        if (validId && validNumOfCopies && validNumOfPublish && validMonth)
        {
            Console.WriteLine("Successfully created!!!");
            return new Magazine(id, publisher, numOfCopies, numOfPublish, (Month)month);
        } else
        {
            Console.WriteLine("Cannot create document since invalid input!");
            return null;
        }

    }

    static Book NewsPaperFactory()
    {
        int id, numOfCopies, numOfPages;
        string publisher, author;
        Console.WriteLine("Enter the input");
        Console.Write("Id: ");
        bool validId = int.TryParse(Console.ReadLine(), out id);
        Console.Write("Publisher: ");
        publisher = Console.ReadLine();
        Console.Write("Number of copies: ");
        bool validNumOfCopies = int.TryParse(Console.ReadLine(), out numOfCopies);
        Console.Write("Author: ");
        author = Console.ReadLine();
        Console.Write("Number of pages: ");
        bool validNumOfPages = int.TryParse(Console.ReadLine(), out numOfPages);
        if (validId && validNumOfCopies && validNumOfPages)
        {
            Console.WriteLine("Successfully created!!!");
            return new Book(id, publisher, numOfCopies, author, numOfPages);
        }
        else
        {
            Console.WriteLine("Cannot create document since invalid input!");
            return null;
        }
    }
}
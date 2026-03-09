using LibraryManagementSystem.Services;
public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            
            
            Console.WriteLine("1. Register Member ");
            Console.WriteLine("2. Display All Members");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter your Choice: ");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
            
                case "1":
                    MemberService.MemberRegister();
                    break;
            
                case "2":
                    MemberService.DisplayMembers();
                    break;
                case "3":
                    running = false;
                    break;
                
            
            
            }
            
            
        }
        

    }
}

// LLD Interview Question
//
//     Design a simple Library Management System.
//
//     The system should support the following:
//
// A library contains multiple books.
//
//     Each book has basic information such as ID, title, and author.
//
//     A member of the library should be able to borrow a book.
//
//     A member should also be able to return a borrowed book.
//
//     A book cannot be borrowed if it is already borrowed by someone else.
//
// When a book is returned, it should become available again.
//
//     You should design the classes, relationships, and main methods required to support this system.
//
//     Focus on:
//
// Object-oriented design
//
//     Clean class structure
//
// Extensibility
//
//     You may assume the system runs in memory (no database required).


// Library Book Member 
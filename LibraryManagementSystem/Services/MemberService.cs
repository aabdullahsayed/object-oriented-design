namespace LibraryManagementSystem.Services;

public class MemberService
{
    private static readonly List<Member> _members = new List<Member>();
    
    public static void MemberRegister()
    {

        Member m = new Member();

        Console.WriteLine("EnterName:");
        m.name = Console.ReadLine();
        
        Console.WriteLine("Enter Contact Number");
        m.ContactNumber = Console.ReadLine();
        
        
        _members.Add(m);

    }

    public static void DisplayMembers()
    {
        foreach (var p in _members)
        {
            Console.WriteLine($"Name: {p.name} | Contact Number {p.ContactNumber}");
        }
    }
    
    
}
using System.Net;

namespace LibraryManagementSystem;

public class Member
{
    public int ID { get; set; }
    public string name { get; set; }
    public string ContactNumber { get; set; }
    
    private static int idd = 1;

    public Member()
    {
        ID = idd++;
    }
    
    
}
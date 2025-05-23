namespace Fitness_Center;

public class SingleClubMember : Member
{
    bool checkIn = false;
    public SingleClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, string memberClub) : base(memberId, memberName, memberPhone, memberEmail, memberAddress)
    {
    }
    

    public override bool CheckIn(Club club)
    {
        checkIn = !checkIn;
        try
        {
            club.Equals(MemberClub);
        }catch (InvalidOperationException message)
        {
            Console.WriteLine(message.Message);
            checkIn=false;
        }

        if (checkIn == true)
        {
            Console.WriteLine($"{MemberName} has been checked in.");
        }
        if  (checkIn == false)
        {
            Console.WriteLine($"{MemberName} has been checked out.");
        }
        return checkIn; 
    }

}
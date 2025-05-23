using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class Club
    {
        private int _clubId;
        private string _clubName;
        private string _clubAddress;
        private string _clubPhone;
       

        public int ClubId { get { return _clubId;  } set { _clubId = value; } }
        public string ClubName { get { return _clubName; } set { _clubName = value; } }
        public string ClubAddress { get { return _clubAddress; } set { _clubAddress = value; } }
        public string ClubPhone { get { return _clubPhone; } set { _clubPhone = value; } }

        public Club(int clubId, string clubName,  string clubAddress, string clubPhone)
        {
            ClubId = clubId;
            ClubName = clubName;
            ClubAddress = clubAddress;
            ClubPhone = clubPhone;
        }

        List<Club> Clubs = new List<Club>();
        List<MultiClubMember> MultiClubMembers = new();
        List<SingleClubMember> SingleClubMembers = new();

        public Club()
        {
            

            Club chicago = new Club(01, "Chicago", "12345 Main Street Chicago, IL 55555", "555-555-5555");
            Clubs.Add(chicago);
            Club detroit = new Club(02, "Detroit", "23456 Woodward Ave Detroit, MI 44444", "123-456-7890");
            Clubs.Add(detroit);
            Club livonia = new Club(03, "Livonia", "98765 Northeast Street Livonia, MI 33333", "234-567-8901");
            Clubs.Add(livonia);
            Club netherlands = new Club(04, "Netherlands", "932 Isle of Green, EU 31", "31-907-3596");
            Clubs.Add(netherlands);
        }

        public void run()
        {

        }

        public void AddMember()
        {
            string memberType;
            do
            {
                Console.WriteLine("What type of member are you adding? Single or Multi?");
                memberType = Console.ReadLine().Trim().ToLower();
                if (memberType == "single")
                {
                    Console.WriteLine("What is the new members member id?");
                    int memberId = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the new members name?");
                    string memberName = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s phone number?");
                    string memberPhone = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s email?");
                    string memberEmail = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s Address?");
                    string memberAddress = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s Club?");
                    string memberClub = Console.ReadLine().Trim();
                    SingleClubMembers.Add(new SingleClubMember(memberId, memberName, memberPhone, memberEmail, memberAddress, memberClub));
                }
                else if (memberType == "multi")
                {
                    Console.WriteLine("What is the new members member id?");
                    int memberId = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the new members name?");
                    string memberName = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s phone number?");
                    string memberPhone = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s email?");
                    string memberEmail = Console.ReadLine().Trim();
                    Console.WriteLine($"What is {memberName}'s Address?");
                    string memberAddress = Console.ReadLine().Trim();
                    int memberPoints = 0;
                    
                    MultiClubMembers.Add(new MultiClubMember(memberId, memberName, memberPhone, memberEmail, memberAddress, memberPoints));
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            } while (memberType != "single" && memberType != "multi");

        }


        public void RemoveMember(int memberId)
        {
            Console.WriteLine("What type of member are you removing? Single or Multi?");
            Console.WriteLine("What is the member # you would like to cancel?");
            memberId = int.Parse(Console.ReadLine());

            
        }

        public void DisplayMember()
        {
            
        }
       
        public int CheckMemberPoints()
        {
            return 0;
        }

        
        
    }
}

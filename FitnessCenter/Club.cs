using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Club> Clubs = new List<Club>();
        public List<Member> ClubMembers = new();
        
        public Club()
        {
            

            Club chicago = new Club(01, "Chicago", "12345 Main Street Chicago, IL 55555", "555-555-5555");
            Clubs.Add(chicago);
            Club detroit = new Club(02, "Detroit", "23456 Woodward Ave Detroit, MI 44444", "123-456-7890");
            Clubs.Add(detroit);
            Club livonia = new Club(03, "Livonia", "98765 Northeast Street Livonia, MI 33333", "234-567-8901");
            Clubs.Add(livonia);
            
        }

        public Club(string club)
        {
            ClubName = club;
            ClubMembers = new List<Member>();

        }

        public void AddMember()
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
            ClubMembers.Add(new MultiClubMember(memberId, memberName, memberPhone, memberEmail, memberAddress, memberClub));
        }


        public void RemoveMember()
        {

        }

        public void DisplayMember()
        {
            foreach (Member member in ClubMembers)
            {
                Console.WriteLine(member);
            } 
            
        }
       
        public int CheckMemberPoints()
        {
            return 0;
        }

        
    }
}

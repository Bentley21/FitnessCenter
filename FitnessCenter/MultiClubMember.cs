using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class MultiClubMember : Member
    {

        private int _memberPoints;
        private List<Club> _clubs = new List<Club>();
        private bool _checkedIn;

        public int MemberPoints {  get { return _memberPoints; } set { _memberPoints = value; } }
        public List<Club> Clubs { get { return _clubs; } set { _clubs = value; } }

        public bool CheckedIn { get { return _checkedIn; } set { _checkedIn = value; } } 

        public MultiClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, int memberPoints, Club club) : base(memberId, memberName, memberPhone, memberEmail, memberAddress)
        {
            MemberPoints = memberPoints;
            Clubs.Add(club);
        }

        
        public override bool CheckIn(Club club)
        {

            if (_checkedIn == true)
            {
                Console.WriteLine($"{MemberName} has been checked in.");
            }
            if (_checkedIn == false)
            {
                Console.WriteLine($"{MemberName} has been checked out.");
            }
            return _checkedIn;
        }

        public int MembershipPoints(int memberPoints, int memberID, string memberName)
        {
            
            memberPoints += 25;
            Console.WriteLine($"Member ID: {memberID} Member Name: {memberName} MemberPoints: {memberPoints}");
            return memberPoints;
        }

        public override void DisplayMember()
        {
            Console.WriteLine("Multi Member Display");
            base.DisplayMember();
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Member Points: {MemberPoints} Member Club: {Clubs} Checked In: {CheckedIn}";
                
        }

        
    }

    
}

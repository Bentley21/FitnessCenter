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

        public int MemberPoints {  get { return _memberPoints; } set { _memberPoints = value; } }
        bool checkIn;

        public MultiClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, int memberPoints) : base(memberId, memberName, memberPhone, memberEmail, memberAddress)
        {
            MemberPoints = memberPoints;
        }

        List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();
        public override bool CheckIn(Club club)
        {

            if (checkIn == true)
            {
                Console.WriteLine($"{MemberName} has been checked in.");
            }
            if (checkIn == false)
            {
                Console.WriteLine($"{MemberName} has been checked out.");
            }
            return checkIn;
        }

        public int MembershipPoints(int memberPoints, int memberID, string memberName)
        {
            
            memberPoints += 25;
            Console.WriteLine($"Member ID: {memberID} Member Name: {memberName} MemberPoints: {memberPoints}");
            return memberPoints;
        }

        
    }

    
}

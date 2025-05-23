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

        public static int MembershipPoints(int memberPoints)
        {
            
            memberPoints += 25;
            return memberPoints;
        }
    }

    
}

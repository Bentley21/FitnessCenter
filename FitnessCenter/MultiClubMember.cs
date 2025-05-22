using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class MultiClubMember : Member
    {
        bool checkIn;
        public MultiClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, string memberClub) : base(memberId, memberName, memberPhone, memberEmail, memberAddress, memberClub)
        {
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

        public static int MemberPoints()
        {
            return 5;
        }
    }

    
}

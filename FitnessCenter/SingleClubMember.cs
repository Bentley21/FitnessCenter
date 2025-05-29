using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class SingleClubMember : Member
    {
        private Club _memberClub;
        bool checkIn = false;

        public Club MemberClub {  get { return _memberClub; } set { _memberClub = value; } }


        public SingleClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, Club memberClub) : base(memberId, memberName, memberPhone, memberEmail, memberAddress)
        {
            MemberClub = memberClub;
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
}

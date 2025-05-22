using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    internal class MultiClubMember : Member
    {
        public MultiClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress, string memberClub) : base(memberId, memberName, memberPhone, memberEmail, memberAddress, memberClub)
        {
        }

        public List<MultiClubMember> multiClubMembers;
        public override bool CheckIn(Club club)
        {

            return false;
        }

        public static int MemberPoints()
        {
            return 5;
        }
    }

    
}

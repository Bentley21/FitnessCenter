using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    internal class SingleClubMember : Member
    {
        public SingleClubMember(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress) : base(memberId, memberName, memberPhone, memberEmail, memberAddress)
        {
        }

        public override bool CheckIn(Club club)
        {
            return false;
        }
    }
}

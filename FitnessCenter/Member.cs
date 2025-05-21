using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public abstract class Member
    {
        private int _memberId;
        private string _memberName;
        private string _memberPhone;
        private string _memberEmail;
        private string _memberAddress;

        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        public string MemberPhone { get { return _memberPhone; } set { _memberPhone = value; } }
        public string MemberEmail { get { return _memberEmail; } set { _memberEmail = value; } }
        public string MemberAddress { get { return _memberAddress; } set { _memberAddress = value; } }

        public Member(int memberId, string memberName, string memberPhone, string memberEmail, string memberAddress)
        {
            MemberId = memberId;
            MemberName = memberName;
            MemberPhone = memberPhone;
            MemberEmail = memberEmail;
            MemberAddress = memberAddress;
        }

        public abstract bool CheckIn(Club club);
       

    }
}

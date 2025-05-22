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

        public List<Club> Clubs;
        public List<Member> ClubMembers;
        
        public Club()
        {
            Clubs = new List<Club>
            {
                new Club(01, "Chicago", "12345 Main Street Chicago, IL 55555", "555-555-5555"),
                new Club(02, "Detroit", "23456 Woodward Ave Detroit, MI 44444", "123-456-7890" ),
                new Club(03, "Livonia", "98765 Northeast Street Livonia, MI 33333", "234-567-8901")
            };
        }

        


        public void RemoveMember()
        {

        }

        public void DisplayMember()
        {

        }
        public double BillMember()
        {
            return 0;
        }

        public int CheckMemberPoints()
        {
            return 0;
        }
    }
}

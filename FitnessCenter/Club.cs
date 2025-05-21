using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class Club
    {
        public List<Club> Clubs;

        public Club()
        {
            Clubs = new List<Club>
            {
                new Club(),
                new Club(),
                new Club()
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

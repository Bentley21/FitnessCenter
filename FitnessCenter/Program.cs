using static System.Reflection.Metadata.BlobBuilder;

namespace FitnessCenter
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Club> clubs = new List<Club>();

            
            clubs.Add(new Club(01, "Chicago", "12345 Main Street Chicago, IL 55555", "555-555-5555"));
            clubs.Add(new Club(02, "Detroit", "23456 Woodward Ave Detroit, MI 44444", "123-456-7890"));
            clubs.Add(new Club(03, "Livonia", "98765 Northeast Street Livonia, MI 33333", "234-567-8901"));
            clubs.Add(new Club(04, "Netherlands", "932 Isle of Green, EU 31", "31-907-3596"));


            Member member = new MultiClubMember(1234, "Darryl", "313-806-0757", "hey@gmail.com", "1234 Street", 25, clubs[0]);
            member.DisplayMember();



        }
        
        
            
    }
}

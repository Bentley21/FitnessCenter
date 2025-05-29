namespace FitnessCenter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();
            Console.WriteLine("Hello, World!");
            Member member = new MultiClubMember(1234, "Darryl", "313-806-0757", "hey@gmail.com", "1234 Street", 25);
            member.DisplayMember();

            club.AddMember(); 
            club.DisplayMember();


        }
        
        
            
    }
}

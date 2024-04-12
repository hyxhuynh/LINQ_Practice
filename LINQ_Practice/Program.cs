using System.Threading.Channels;

namespace LINQ_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameList = new List<string>()
            {
                "Super Mario Bros Wonder", "Ark: Survival Ascended", "Rise of the Ronin", "Helldiver", "Call of Duty", "A Space for the Unbound", "Stardew Valley", "Outer Wilds", "Pro Evolution Soccer", "The Sims", "Final Fantasy X", "Pokemon Legends Arceus"
            };

            videoGameList.OrderBy(x => x.Length)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}

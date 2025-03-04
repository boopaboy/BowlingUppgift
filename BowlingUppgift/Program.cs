using BowlingUppgift.Entities;
using BowlingUppgift.Factory;
using System.Text.RegularExpressions;
namespace BowlingUppgift
{
    internal class Program
    {

        List<Player> players = new List<Player>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Program program = new Program();
                program.MainMenu();
        }




        private void MainMenu()
        {
         
            
            Console.Clear();
            Console.WriteLine("Välkommen till Bowling");
            Console.WriteLine("Välj en av följande alternativ:");
            Console.WriteLine("1. Skapa ny spelare");
            Console.WriteLine("2. Spela match");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreatePlayer();
                    break;
                case "2":
                    SimulateMatch();
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        private void SimulateMatch() { 

            if (players.Count < 2)
            {
                Console.WriteLine("Du måste skapa minst 2 spelare. Tryck för att fortsätta" );
                Console.ReadKey();
                MainMenu();
            }

            else { 

           for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {players[i].Name}");
            }

            Console.WriteLine("Välj spelare 1:");
            var player1 = players[int.Parse(Console.ReadLine()) - 1];
            Console.WriteLine("Välj spelare 2:");
            var player2 = players[int.Parse(Console.ReadLine()) - 1];
            var match = MatchFactory.Create(player1 , player2);
            match.SimulateMatch();
            Console.WriteLine($"Vinnare: {match.Winner.Name}");
            }
        }

        private void CreatePlayer() {
            Console.Clear();
            Console.WriteLine("Ange spelarens namn:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            { 
                Console.WriteLine("Ogiltigt namn. Får inte vara tomt. Tryck på valfri knapp för att försöka igen.");
                Console.ReadKey(); 
                CreatePlayer(); 
            }
            else
            {
            var player = PlayerFactory.CreatePlayer(name);
            Console.WriteLine($"Ny spelare skapad: {player.Name}");
            players.Add(player);
            Console.ReadKey();
            MainMenu();
            }
        } 
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
    }

    interface ITeam
    {
        void Add(Player player);
        void Remove(int PlayerId);

        Player GetPlayerById(int PlayerId);

        Player GetPlayerByName(string PlayerName);

        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {


            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                Console.Write("Enter Player Id:");
                player.PlayerId = int.Parse(Console.ReadLine());
                Player rem = oneDayTeam.Find(x => x.PlayerId == player.PlayerId);
                if(rem== null)
                {
                    Console.Write("Enter Player Name:");
                    player.PlayerName = Console.ReadLine();
                    Console.Write("Enter Player Age:");
                    player.PlayerAge = int.Parse(Console.ReadLine());
                    oneDayTeam.Add(player);
                    Console.WriteLine("Player Added Sucessfully");

                }
                else
                {
                    Console.WriteLine("Player Id already exists");
                }
                
                
            }
            else
            {
                Console.WriteLine("No more players can be added..\n Total No of Players is "+ oneDayTeam.Count);
            }



        }
        public Player GetPlayerById(int PlayerId)
        {
            Console.Write("Enter Player Id:");
            PlayerId = int.Parse(Console.ReadLine());
            Player rem = oneDayTeam.Find(x => x.PlayerId == PlayerId);
            if(rem != null)
            {
                Console.Write(rem.PlayerId + " ");
                Console.Write(rem.PlayerName + " ");
                Console.Write(rem.PlayerAge + " ");
                
            }
            else
            {
                Console.WriteLine("Player ID not found in the List");
            }
            
            return rem;

        }

        public Player GetPlayerByName(string PlayerName)
        {
            Console.Write("Enter Player Name:");
            PlayerName = Console.ReadLine();
            Player rem = oneDayTeam.Find(x => x.PlayerName == PlayerName);
            if(rem != null) {
                Console.Write(rem.PlayerId + " ");
                Console.Write(rem.PlayerName + " ");
                Console.Write(rem.PlayerAge + " ");
                
            }
            else
            {
                Console.WriteLine("Player Name not found in the List");

            }
            return rem;


        }

        public List<Player> GetAllPlayers()
        {
            foreach (Player player in oneDayTeam)
            {
                Console.Write(player.PlayerId+" ");
                Console.Write(player.PlayerName+" ");
                Console.Write(player.PlayerAge + " ");
                Console.WriteLine();
            }
            return oneDayTeam;
        }

       

        public void Remove(int PlayerId)
        {
            Console.Write("Enter Player Id to Remove:");
            PlayerId = int.Parse(Console.ReadLine());
            Player rem = oneDayTeam.Find(x => x.PlayerId == PlayerId);
            if(rem != null) { oneDayTeam.Remove(rem);
                Console.WriteLine("Player is removed Successfully");
            }
            else { Console.WriteLine("Player ID not found in the List");}
            

        }
    }
}

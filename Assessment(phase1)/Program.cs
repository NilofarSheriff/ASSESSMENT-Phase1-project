using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace Assessment_phase1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "Yes";
            
            OneDayTeam ChennaiSuperKings = new OneDayTeam();
            while (op == "Yes")
            {
                Console.Write("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players: ");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        {
                            Player player = new Player();
                       
                            ChennaiSuperKings.Add(player);
                            break;
                        }
                    case 2:
                        {
                            Player player = new Player();
                            ChennaiSuperKings.Remove(player.PlayerId);
                            break;
                        }
                    case 3:
                        {
                            Player player = new Player();
                            ChennaiSuperKings.GetPlayerById(player.PlayerId);
                            break;
                        }
                    case 4:
                        {
                            Player player = new Player();
                            ChennaiSuperKings.GetPlayerByName(player.PlayerName);
                            break;
                        }
                    case 5:
                        {
                            Player player = new Player();
                            ChennaiSuperKings.GetAllPlayers();
                            break;
                        }
                }
                Console.WriteLine();
                Console.Write("Do you want to continue (Yes/No) ? ");
                string ans = Console.ReadLine();
                if (ans == "Yes" || ans=="yes") 
                {
                    op = "Yes";
                }
                else
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

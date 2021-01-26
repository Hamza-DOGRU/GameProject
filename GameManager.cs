using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : ISalesManager
    {
        public void SellingGames(Gamer gamer, Campaing campaing, Game game)
        {
            Console.WriteLine("Tebrikler "+gamer.FirstName+" "+campaing.SerialNumber+" Nolu kampanyadan faydalanıp "+game.GameName+" İsimli Oyunu Satın aldın");
        }

        public void SellingGamesWithCampaign(Gamer gamer, Game game, Campaing campaing)
        {
            
            Console.WriteLine("Tebrikler "+gamer.FirstName+" "+campaing.SerialNumber+" Nolu kampanyadan faydalanıp ");
        }
    }
}

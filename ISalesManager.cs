using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesManager
    {
        void SellingGamesWithCampaign(Gamer gamer,Game game,Campaing campaing);
        void SellingGames(Gamer gamer,Campaing campaing,Game game);
    }
}

using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.UserName = "asdasdas";
            gamer1.FirstName = "Hamza";
            gamer1.LastName = "DOĞRU";

            Campaing campaing1 = new Campaing();
            campaing1.SerialNumber = 2313321;
            campaing1.StartingDate = new DateTime(1995, 5, 5);
            campaing1.EndDate = new DateTime(2021, 2, 2);

            Game game1 = new Game();
            game1.GameName = "LOL";
            game1.ReleaseDate = new DateTime(2002, 2, 2);
            game1.Price = 55;

            RegistorManager registorManager = new RegistorManager();
            IManager gamermanager = new GamerManager();
            CampaingManager campaingManager = new CampaingManager();
            ISalesManager salesManager = new GameManager();
            salesManager.SellingGames(gamer1, campaing1,game1);
            registorManager.Update(campaingManager);
            registorManager.Delete(gamermanager);
            
            
            
            



        }
    }
}

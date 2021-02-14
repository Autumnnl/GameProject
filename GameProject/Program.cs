using System;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject

{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player { Name = "BATU",Surname ="YILDIZ",BirthDate = 2000,Id = 1 , TcNo = "12345"};
            Game game = new Game {GameName = "Persona 5 ",GameType ="RP", GamePrice =558 };
            Game game2 = new Game { GameName = "Final Fantasy VIII", GameType = "RP", GamePrice = 75 };
            Campaign campaign = new Campaign {CampaignName = "Spring Sale", SaleAmount = "%30",CampaignDescription ="Let Your Spring Shine with lots of games!" };

            ICampaignService campaignService = new CampaignService();

            IPlayerService playerService = new PlayerService(new CheckPlayerManager());
            IGameService gameService = new GameService();
            gameService.Add(game);
            playerService.Add(player);
            campaignService.Add(campaign);





        }
    }
}

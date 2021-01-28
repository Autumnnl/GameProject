using System;

namespace GameProject

{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.Player player = new Entities.Player { Name = "BATU",Surname ="YILDIZ",BirthDate = 2000,Id = 1 , TcNo = "12345"};
            Entities.Game game = new Entities.Game {GameName = "Persona 5 ",GameType ="RP", GamePrice =558 };
            Entities.Game game2 = new Entities.Game { GameName = "Final Fantasy VIII", GameType = "RP", GamePrice = 75 };
            Entities.Campaign campaign = new Entities.Campaign {CampaignName = "Spring Sale", SaleAmount = "%30",CampaignDescription ="Let Your Spring Shine with lots of games!" };

            Abstract.ICampaignService campaignService = new Concrete.CampaignService();

            Abstract.IPlayerService playerService = new Concrete.PlayerService(new  Concrete.CheckPlayerManager());
            Abstract.IGameService gameService = new Concrete.GameService();
            gameService.Add(game);
            playerService.Add(player);
            campaignService.Add(campaign);





        }
    }
}

using System;

namespace GameIntro
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            Game fpsGame = new FpsGame();
            Game survivalGame = new SurvivalGame();
            Game racingGame = new RacingGame();


            Campaign campaign1 = new Campaign() { Id = 1, Explanation = "Haftasonu İndirimi", CampaingCount = 5 };
            CampaignManage campaignManage = new CampaignManage();
            campaignManage.Add(campaign1);
            Console.WriteLine("Kampanya Sayımız:"+ campaignManage.Campaigns.Count);

            Gamer gamer1 = new Gamer() {Id=1, FirstName="Kemal",LastName = "Yoğurt",TcNo ="12345678910",BornDate="11/07/1999" };
            GamerManager gamerManager = new GamerManager();
            gamerManager.SignUp(gamer1);
            Console.WriteLine();
            //Console.WriteLine("-------------------");
            //foreach (var gamer in gamerManager.Gamers)
            //{
            //    Console.WriteLine(gamer.FirstName);
            //}
            gamerManager.GetBuy(racingGame, gamer1);
            Console.WriteLine("-------------------------------------");
            gamerManager.GedBargainBuy(racingGame, gamer1, campaign1);
            
            
            //gamerManager.Delete(gamer1);
            //foreach (var gamer in gamerManager.Gamers)
            //{
            //    Console.WriteLine(gamer.FirstName);
            //}
            Console.WriteLine("---------------------------");
            //gamerManager.Update(gamer1);
            //gamerManager.Validation(gamer1);
            Console.ReadLine();
        }
     
    }
}

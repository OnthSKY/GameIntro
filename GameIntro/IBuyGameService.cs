namespace GameIntro
{
    partial class Program
    {
        interface IBuyGameService
        {

            void GetBuy(Game game, Gamer gamer);

            void GedBargainBuy(Game game, Gamer gamer, Campaign campaign);
        }
    }
}

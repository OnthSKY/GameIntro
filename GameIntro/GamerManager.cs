using System.Collections.Generic;

namespace GameIntro
{
    partial class Program
    {
        class GamerManager : IGamerService , IBuyGameService
        {
            ValidationManager validationManager;
            List<Gamer> gamers;
            public List<Gamer> Gamers
            {
                get { return gamers; }
                private set { gamers = value; }
            }

            public GamerManager()
            {
                gamers = new List<Gamer>();
                validationManager = new ValidationManager();

            }
         
            public void Delete(Gamer gamer)
            {
                System.Console.WriteLine("Id: {0} olan {1} adlı kullanıcı başarıyla silinmiştir.", gamer.Id, gamer.FirstName);
                gamers.Remove(gamer);                       
            }

            public void SignUp(Gamer gamer)
            {
                if(validationManager.Validation(gamer) == true)
                {
                    this.gamers.Add(gamer);
                    System.Console.WriteLine("Id: {0} olan {1} adlı kullanıcı başarıyla kayıt edilmiştir.", gamer.Id, gamer.FirstName);
                }
                else
                    System.Console.WriteLine("E- Devlet üzerinden eşleşme yapılamadığı için kayıt başarısız olmuştur. Lütfen sonra tekrar deneyin");
                
            }

            public void Update(Gamer gamer)
            {
                System.Console.WriteLine("Veri Tabanı ile Güncelleme yapılmıştır.");
            }
           
            public void GetBuy(Game game, Gamer gamer)
            {
                System.Console.WriteLine("\t-----Satın Alım Sayfası----");
                gamer.Games.Add(game);
                System.Console.WriteLine("->Kullanıcı: " + gamer.FirstName+"\n---Oyun Adı: "+ game.Name+"\n---Fiyat: "+game.Price +"TL " +"\n--->satın alındı. ");
            }

            public void GedBargainBuy(Game game, Gamer gamer, Campaign campaign)
            {
                double bargainPrice =  game.Price - (game.Price * campaign.CampaingCount /100);
                gamer.Games.Add(game);
                System.Console.WriteLine("->Kullanıcı: " + gamer.FirstName + "\n---Oyun Adı: " + game.Name + "\n---Fiyat: " + game.Price + "TL "+ "\n---İndirimli Fiyat:"+bargainPrice+ "\n--->satın alındı. ");
            }

            public void Create(Gamer gamer)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}

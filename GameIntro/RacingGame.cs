namespace GameIntro
{
    partial class Program
    {
        class RacingGame : Game
        {
            public RacingGame()
            {
                // Ekstra bilgileri yazmak yerine Sınıftan nesne oluşturduğum zaman default değer atadım.
                this.Id = 1;
                this.Name = "Forza Horizon";
                this.Price = 450;
            }
        }
    }
}

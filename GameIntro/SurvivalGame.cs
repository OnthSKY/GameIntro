namespace GameIntro
{
    partial class Program
    {
        class SurvivalGame : Game
        {
            public SurvivalGame()
            {
                // Ekstra bilgileri yazmak yerine Sınıftan nesne oluşturduğum zaman default değer atadım.
                this.Id = 1;
                this.Name = "Minecraft";
                this.Price = 100;
            }
        }
    }
}

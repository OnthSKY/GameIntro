namespace GameIntro
{
    partial class Program
    {
        class FpsGame : Game
        {
            public FpsGame()
            {
                // Ekstra bilgileri yazmak yerine Sınıftan nesne oluşturduğum zaman default değer atadım.
                this.Id = 1;
                this.Name = "Call Of Duty";
                this.Price = 500;
            }
        }
    }
}

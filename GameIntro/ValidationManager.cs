namespace GameIntro
{
    partial class Program
    {
        class ValidationManager : IValidationService
        {
            public bool Validation(Gamer gamer)
            {
                if (gamer.TcNo == "12345678910")
                    return true;
                else if (gamer.TcNo == "00000000000")
                    return true;
                else
                    return false;
            }
        }
    }
}

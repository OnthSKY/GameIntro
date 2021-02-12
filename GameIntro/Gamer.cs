using System.Collections.Generic;

namespace GameIntro
{
    partial class Program
    {
        public class Gamer
        {
            public int Id { get; set; }
            public string TcNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string BornDate { get; set; }
            public List<Game> Games { get; set; }

            public Gamer()
            {
                Games = new List<Game>() { };
            }

        }
    }
}

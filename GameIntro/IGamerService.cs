using System.Collections.Generic;

namespace GameIntro
{
    partial class Program
    {
        interface IGamerService
        {
            void Create(Gamer gamer);

            void Update(Gamer gamer);

            void Delete(Gamer gamer);
        }
      
    }
}

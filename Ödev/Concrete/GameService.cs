using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameService:Abstract.IGameService
    {

        public void Add(Entities.Game game)
        {
            Console.WriteLine("Added! :" + game.GameName);

        }
        public void Update(Entities.Game game)
        {
            Console.WriteLine("Updated! :" + game.GameName);

        }
        public void Delete(Entities.Game game)
        {
            Console.WriteLine("Deleted! :" + game.GameName);

        }
    }
}

using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameService:IGameService
    {

        public void Add(Game game)
        {
            Console.WriteLine("Added! :" + game.GameName);

        }
        public void Update(Game game)
        {
            Console.WriteLine("Updated! :" + game.GameName);

        }
        public void Delete(Game game)
        {
            Console.WriteLine("Deleted! :" + game.GameName);

        }
    }
}

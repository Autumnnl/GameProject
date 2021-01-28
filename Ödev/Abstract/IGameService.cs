using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void Add(Entities.Game game);
        void Update(Entities.Game game);
        void Delete(Entities.Game game);
    }
}

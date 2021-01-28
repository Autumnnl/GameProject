using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IPlayerService
    {
        void Add(Entities.Player player);

        void Update(Entities.Player player);

        void Delete(Entities.Player player);
    }
} 
            

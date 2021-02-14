using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IPlayerService
    {
        void Add(Player player);

        void Update(Player player);

        void Delete(Player player);
    }
} 
            

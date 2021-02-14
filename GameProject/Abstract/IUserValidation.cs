using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IUserValidation
    {
        bool Validate(Player player);
    }
}

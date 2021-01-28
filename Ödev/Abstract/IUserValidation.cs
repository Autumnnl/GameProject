using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserValidation
    {
        bool Validate(Entities.Player player);
    }
}

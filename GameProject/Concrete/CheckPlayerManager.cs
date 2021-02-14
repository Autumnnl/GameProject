using MernisServiceReference;
using GameProject.Entities;
using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CheckPlayerManager : IUserValidation
    {
        public bool Validate(Player player)
        {
            if (player.BirthDate == 2000 && player.Name =="BATU" && player.Surname == "YILDIZ" && player.TcNo == "12345" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
	

	}
    
}

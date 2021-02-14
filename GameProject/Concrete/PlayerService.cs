using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerService:IPlayerService
    {
        IUserValidation _userValidation;

        public PlayerService(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Player player)
        {
            if (_userValidation.Validate(player)==true)
            {
                Console.WriteLine("Welcome, " + player.Name);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.Kayıt Yapılamadı");
            }

        }
        public void Update(Player player)
        {
            Console.WriteLine("Updated!! " + player.Name);

        }
        public void Delete(Player player)
        {
            Console.WriteLine("Deleted : " + player.Name);

        }





    }
}

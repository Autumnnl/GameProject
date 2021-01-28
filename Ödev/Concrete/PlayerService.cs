using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerService:Abstract.IPlayerService
    {
        Abstract.IUserValidation _userValidation;

        public PlayerService(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Entities.Player player)
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
        public void Update(Entities.Player player)
        {
            Console.WriteLine("Updated!! " + player.Name);

        }
        public void Delete(Entities.Player player)
        {
            Console.WriteLine("Deleted : " + player.Name);

        }





    }
}

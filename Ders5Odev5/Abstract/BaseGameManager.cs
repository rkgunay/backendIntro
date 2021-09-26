using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public virtual void Add(Game game)
        {
            Console.WriteLine("Yeni oyun eklendi." + "\n" + game.GameName + "\n" + game.GamePrice);
        }

        public virtual void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi." + "\n" + game.GameName + "\n" + game.GamePrice);
        }

        public virtual void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi." + "\n" + game.GameName + "\n" + game.GamePrice);
        }
    }
}

using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    public class MobileGameManager : BaseGameManager
    {
        public override void Add(Game game)
        {
            Console.WriteLine("\n \n Mobil Oyun: \n");
            base.Add(game);
        }
        public override void Delete(Game game)
        {
            Console.WriteLine("\n \n Mobil Oyun: \n");
            base.Delete(game);
        }
        public override void Update(Game game)
        {
            Console.WriteLine("\n \n Mobil Oyun: \n");
            base.Update(game);
        }
    }
}

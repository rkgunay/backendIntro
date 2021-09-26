using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    public class SalesManager
    {
        public void AddSale(User user, Game game)
        {
            Console.WriteLine("\n \n ----Satış Bilgileri---- \n");
            Console.WriteLine("Müşteri Adı: "+user.FirstName + " " +user.LastName );
            Console.WriteLine("Oyun Adı: " + game.GameName);
            Console.WriteLine("Oyun Fiyatı: " + game.GamePrice);
        }
        public void AddSale(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("\n \n ----Satış Bilgileri---- \n");
            Console.WriteLine("Müşteri Adı: " + user.FirstName + " " + user.LastName);
            Console.WriteLine("Oyun Adı: " + game.GameName + "\nOyunun İndirimsiz Fiyatı: " + game.GamePrice +"\n");

            Console.WriteLine("Kampanya Adı: " + campaign.CampaignName);
            Console.WriteLine("Kampanya Bilgileri: " + campaign.CampaignDefinition);

            Console.WriteLine("İndirim Oranı: %" + campaign.DiscountPercentage);

            Console.WriteLine("Oyunun İndirimli Fiyatı: " + 
                game.GamePrice * ((100 - campaign.DiscountPercentage)/100));


           

            
        }
    }
}

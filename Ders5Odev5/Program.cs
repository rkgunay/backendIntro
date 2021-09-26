using Ders5Odev5.Abstract;
using Ders5Odev5.Adapters;
using Ders5Odev5.Concrete;
using Ders5Odev5.Entities;
using System;

namespace Ders5Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni bir kampanya ürettik. 
            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Yaz Sonu Çılgınlığı",
                CampaignDefinition = "Bütün oyunlarda %30 indirim",
                DiscountPercentage = 30,
                StartTime = new DateTime(2021, 8, 15),
                EndTime = new DateTime(2021, 9, 15)
            };

            // Seasonal Campaign Manager sınıfını örneklediğimizde konsola önce 'Sezon Kampanyası:' yazdırdı.
            //Sonra 'Add' fonksiyonunda yazmasını söylediklerimizi yazdı. 
            //Special Campaign Manager sınıfını örnekleseydik 'Özel Kampanya:' yazacaktı.
            BaseCampaignManager campaignManager1 = new SeasonalCampaignManager();
            campaignManager1.Add(campaign1);


            //Yeni kullanıcı Ürettik. 
            User user1 = new User()
            {
                Id = 1,
                FirstName = "Rıdvan Kadir",
                LastName = "Günay",
                NationalityId = "11111111111",
                DateOfBirth = new DateTime(1800, 5, 20)

            };

            //bu sınıfı örneklerken verdiğimiz parametre ile BaseUseManager sınıfına hangi
            //kimlik doğrulama servisinin CheckIfRealPerson fonksiyonunu kullanacağı bilgisini verdik.
            //Direkt BasicUserManager sınıfında da örnekleyebilirdik Mernis'i. Ama o zaman yeni
            //kimlik doğrulama sistemi geldiği zaman kodlarımızı değiştirmek zorunda kalırdık. 
            //Aşağıda da Kullanıcı bilgileri hatalı gelecek ekrana. Çünkü user1'deki bilgiler yanlış. 
            BaseUserManager userManager = new BasicUserManager(new MernisServiceAdapter());
            userManager.Add(user1);


            //2 yeni oyun oluşturduk.
            Game game1 = new Game() {
                Id = 1,
                GameName = "Kafa Topu 2",
                GamePrice = 10,
            };
            Game game2 = new Game()
            {
                Id = 1,
                GameName = "Mount and Blade",
                GamePrice = 100,
            };

            //2 oyunu da sisteme eklemeyi simüle ettik.
            BaseGameManager gameManager1 = new MobileGameManager();
            gameManager1.Add(game1);

            BaseGameManager gameManager2 = new PcGameManager();
            gameManager2.Add(game2);

            //Satış sınıfını örnekledik.
            SalesManager salesManager = new SalesManager();
           
            //Kampanyasız bir satış simülasyonu yaptık.
            salesManager.AddSale(user1,game1);

            //Kampanyalı bir satış simülasyonu yaptık.
            salesManager.AddSale(user1, game2, campaign1);
           
        }
    }
}

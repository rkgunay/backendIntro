using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    public class BasicUserManager : BaseUserManager
    {

        private IUserCheckService _userCheckService;

        public BasicUserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("\n \n Standart Kullanıcı: \n");
                base.Add(user);
            }
            else
            {
                Console.WriteLine("\n \nGerçek kişi bilgileri girmediniz.");
            }
        }
        public override void Delete(User user)
        {
            Console.WriteLine("\n \n Standart Kullanıcı: \n");
            base.Delete(user);
        }
        public override void Update(User user)
        {
            Console.WriteLine("\n \n Standart Kullanıcı: \n");
            base.Update(user);
        }
    }
}

using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Yeni kullanıcı eklendi." + "\n" + user.FirstName + " " + user.LastName);
        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi." + "\n" + user.FirstName + " " + user.LastName);
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Kullanıcı güncellendi." + "\n" + user.FirstName + " " + user.LastName);
        }
    }
}

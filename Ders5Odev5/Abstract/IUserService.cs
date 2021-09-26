using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Abstract
{
    public interface IUserService
    {
        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);
    }
}

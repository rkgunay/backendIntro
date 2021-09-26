using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}

using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                        Convert.ToInt64(user.NationalityId), 
                        user.FirstName.ToUpper(),
                        user.LastName.ToUpper(), 
                        user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

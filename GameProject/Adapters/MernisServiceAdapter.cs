using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient soapClient = new MernisServiceReference.KPSPublicSoapClient();
            return soapClient.TCKimlikNoDogrula(long.Parse(gamer.Identity), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev1_
{
    public class CardFactory : IFactory
    {
        public KrediKarti Olustur(Kayit kayit)
        {
            int FirstNumber = int.Parse(kayit.KartNo[0].ToString());
            int SecondNumber = int.Parse(kayit.KartNo[1].ToString());
            
            if (FirstNumber==5 && (SecondNumber > 1 && SecondNumber < 5) && kayit.KartNo.Length==16)
            {
                return new MasterCard(kayit.KartNo, kayit.KartSahibi, kayit.SonKullanmaTarihi);
            }
            else if (FirstNumber==4  && (kayit.KartNo.Length == 16 || kayit.KartNo.Length == 13))
            {
                return new Visa(kayit.KartNo, kayit.KartSahibi, kayit.SonKullanmaTarihi);

            }
            else if(FirstNumber== 3 && (SecondNumber== 1 || SecondNumber ==7)  && kayit.KartNo.Length == 15)
            {
                return new AmericanExpress(kayit.KartNo, kayit.KartSahibi, kayit.SonKullanmaTarihi);
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev1_
{
    public class AmericanExpress:KrediKarti
    {
        public AmericanExpress(string kartno, string kartsahibi,string tarih)
        {
            this.KartNo = kartno;
            this.KartSahibi = kartsahibi;
            this.SonKullanmaTarihi = tarih;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev1_
{
    public class MasterCard:KrediKarti
    {
        public MasterCard(string kartno,string kartsahibi,string tarih)
        {
            this.KartNo = kartno;
            this.KartSahibi = kartsahibi;
            this.SonKullanmaTarihi = tarih;
        }
    }
}

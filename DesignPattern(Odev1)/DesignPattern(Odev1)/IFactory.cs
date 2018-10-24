using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev1_
{
    public interface IFactory
    {
        KrediKarti Olustur(Kayit kayit);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev2_
{
    public class DusmanOlustur:IDusman
    {
        DusmanTank Tank;
       public DusmanAdapter adapter;

        public void SilahKullan()
        {
            Tank.SilahKullan();
            adapter.SilahKullan();
        }

        public void Hızlan()
        {
            Tank.Hızlan();
            adapter.Hızlan();
        }

        public void DusmanAdi()
        {
            System.Windows.Forms.MessageBox.Show(Tank.isim);
            adapter.DusmanAdi();
        }
        public DusmanOlustur()
        {
            Tank= new DusmanTank();
        }
    }
}

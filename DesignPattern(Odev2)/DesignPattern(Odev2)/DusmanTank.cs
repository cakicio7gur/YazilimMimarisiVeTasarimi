using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev2_
{
    public class DusmanTank : IDusman
    {
        public string isim { get; set; }
        public void DusmanAdi()
        {
            this.isim = "Düşman Tankı";
        }

        public void Hızlan()
        {
            System.Windows.Forms.MessageBox.Show("Tank Hızlandı");
        }

        public void SilahKullan()
        {
            System.Windows.Forms.MessageBox.Show("Silah Kullanıldı");
        }
    }
}

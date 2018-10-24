using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev2_
{
    public class DusmanRobot : IRobot
    {
        public string RobotAdi { get; set; }
        public void RobotIsım()
        {
            System.Windows.Forms.MessageBox.Show(RobotAdi);
        }

        public void YumrukAt()
        {
            System.Windows.Forms.MessageBox.Show("Yumruk Atıldi");
        }

        public void Yuru()
        {
            System.Windows.Forms.MessageBox.Show("Yürüme işlemi yapıldı");
        }
    }
}

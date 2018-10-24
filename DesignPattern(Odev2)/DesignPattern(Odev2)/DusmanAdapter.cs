using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Odev2_
{
    public class DusmanAdapter : IDusman
    {
        IRobot NewRobot;
        public void DusmanAdi()
        {
            NewRobot.RobotIsım();
        }

        public void Hızlan()
        {
            NewRobot.Yuru();
        }

        public void SilahKullan()
        {
            NewRobot.YumrukAt();
        }
        public DusmanAdapter(IRobot instance)
        {
            this.NewRobot = instance;       
        }
        
    }
}

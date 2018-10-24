using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern_Odev2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DusmanOlustur Ordu = new DusmanOlustur();
            DusmanRobot Robot = new DusmanRobot();
            DusmanAdapter Entegre = new DusmanAdapter(Robot);
            Ordu.adapter = Entegre;
            Ordu.DusmanAdi();
            Ordu.Hızlan();
            Ordu.SilahKullan();
        }
    }
}

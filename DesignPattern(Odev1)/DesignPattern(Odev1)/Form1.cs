using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern_Odev1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kayit k1 = new Kayit();
            k1.KartNo = "5324896571235973";
            k1.KartSahibi = "Ali";
            k1.SonKullanmaTarihi = "05/11/2022";
            Kayit k2 = new Kayit();
            k2.KartNo = "4257893456218";
            k2.SonKullanmaTarihi = "06/04/2021";
            k2.KartSahibi = "Ahmet";
            Kayit k3 = new Kayit();
            k3.KartNo = "375489673145631";
            k3.KartSahibi = "Mehmet";
            k3.SonKullanmaTarihi = "02/01/2023";

           
            List<Kayit> Kayıtlar = new List<Kayit>();
            Kayıtlar.Add(k1);
            Kayıtlar.Add(k2);
            Kayıtlar.Add(k3);
            CardFactory KardFabrika = new CardFactory();
                 
            foreach(Kayit kayit in Kayıtlar)
            {
                KrediKarti Kart = KardFabrika.Olustur(kayit);
            }

        }
    }
}

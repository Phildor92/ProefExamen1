using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProefExamen
{
    public partial class FrmLedenSportclubKlasse : Form
    {        
        public FrmLedenSportclubKlasse()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Lid lid1 = new ProefExamen.Lid("Verbist Alex", 2, 7);
            InformatieRegels(lid1.InformatieVolledig());
            Lid lid2 = new ProefExamen.Lid("Adams Els", 3, 5);
            InformatieRegels(lid2.InformatieVolledig());
            Lid lid3 = lid1;
            InformatieRegels(lid3.InformatieVolledig());
            lid1.VerhoogKlassement();
            InformatieRegels("Gegevens lid1 na verhoging van het klassement van lid1:\r\n" + lid1.InformatieVolledig());
            lid2.VerhoogKlassement();
            InformatieRegels("Gegevens lid2 na verhoging van het klassement van lid2:\r\n" + lid2.InformatieVolledig());
            lid1.VerhoogKlassement();
            InformatieRegels("Gegevens lid3 na (2de) verhoging van het klassement van lid1:\r\n" + lid3.InformatieVolledig());
        }

        private void InformatieRegels(String text)
        {
            txtResultaat.AppendText(text + "\r\n\r\n");
        }
    }
}

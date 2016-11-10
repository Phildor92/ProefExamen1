using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverzichtBezoeken
{
    public partial class FrmNotaris : Form
    {
        string[] bezoekenArray;
        string[] medewerkerArray;
        private Random maakRand = new Random();
        public FrmNotaris()
        {
            InitializeComponent();
        }

        private void FrmNotaris_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bezoekenArray = readTxtFile(@"C:\Users\philip.evans\Documents\PCVO Limburg - HBO5 Informatica\programmeren\proefexamen\notarisBezoeken.txt");
            medewerkerArray = readTxtFile(@"C:\Users\philip.evans\Documents\PCVO Limburg - HBO5 Informatica\programmeren\proefexamen\notarisMedewerkers.txt");

            string[] naamArray = new string[medewerkerArray.Length];
            for (int i = 0; i < 4; i++)
            {
                naamArray[i] = medewerkerArray[i].Substring(2);                
            }
            lstMedewerkers.Items.AddRange(naamArray);
            lstMedewerkers.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try{ 
                imgRand.Image = Image.FromFile(@"C:\Users\philip.evans\Documents\PCVO Limburg - HBO5 Informatica\programmeren\img\beeld " + maakRand.Next(1,21) + ".jpg");
            }
            catch (FileNotFoundException f)
            {
                imgRand.Hide();
            }
        }

        private string[] readTxtFile(string fileLocation)
        {
            string[] readTxt = File.ReadAllLines(fileLocation);
            return readTxt;
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            txtResultaat.Clear();
            string medFull = lstMedewerkers.SelectedItem.ToString();
            string[] medInit = medFull.Split(' ');
            string med = medInit[0].Substring(0, 1) + medInit[1].Substring(0, 1);
            txtResultaat.AppendText("Bezoeken van " + medFull + "\r\n\r\n");

            for (int i = 0; i < bezoekenArray.Length; i++)
            {
                    if (bezoekenArray[i].Substring(10,2) == med)
                    {
                        txtResultaat.AppendText(String.Format("{0}: {1}", bezoekenArray[i].Substring(0, 10), Convert.ToInt32(bezoekenArray[i].Substring(12)) + " minuten\r\n"));
                }               
            }
        }

        private void btnToonTijdOverzichten_Click(object sender, EventArgs e)
        {
            //FrmTijdOverzichten
        }
    }
}

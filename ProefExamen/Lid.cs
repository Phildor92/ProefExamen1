using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProefExamen
{
    class Lid
    {
        private int categorie;
        private int klassement;

        public string NaamVoornaam
        {
            get;
            set;
        }

        public int Categorie
        {
            get { return categorie; }
            set
            {
                if (value >= 0 && value < 4)
                {
                    categorie = value;
                }
            }
        }

        public int Klassement
        {
            get { return klassement; }
            set
            {
                if (value >= 0 && value < 11)
                {
                    klassement = value;
                }
            }
        }

        public Lid()
        {
            Klassement = 0;
            Categorie = 0;
            NaamVoornaam = "";
        }

        public Lid(string naamVoornaam, int categorie, int klassement)
        {
            Klassement = klassement;
            Categorie = categorie;
            NaamVoornaam = naamVoornaam;
        }

        public void VerhoogKlassement()
        {
            Klassement++;
        }

        public void VerlaagKlassement()
        {
            Klassement--;
        }

        public string CategorieOmschrijving()
        {
            if(Categorie == 0)
            {
                return "duivel";
            } else if(Categorie == 1)
            {
                return "miniem";
            } else if(Categorie == 2)
            {
                return "junior";
            } else
            {
                return "senior";
            }
        }

        public double Inschrijvingsgeld()
        {
            double inschrijfgeld;

            if(Categorie == 0)
            {
                inschrijfgeld = 100;
            } else if (Categorie == 1) {
                inschrijfgeld = 150;
            } else if (Categorie == 2)
            {
                inschrijfgeld = 200;
            } else
            {
                inschrijfgeld = 220;
            }
            if(Klassement > 7)
            {
                inschrijfgeld /= 2; //inschrijfgeld *= 0.5
            } else if(Klassement == 6 || Klassement == 7)
            {
                inschrijfgeld *= 0.8;
            }

            return inschrijfgeld;
        }

        public string InformatieVolledig()
        {
            return NaamVoornaam + "\r\n" + CategorieOmschrijving() + "\r\n" + Klassement + "\r\n" + Inschrijvingsgeld();
        }
    }
}

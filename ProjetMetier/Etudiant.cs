using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ProjetMetier
{
    public class Etudiant
    {
        private int idEtudiant;

        private string nomEtudiant;

        private List<Retard> lesRetards;

        public Etudiant(int unId,string unNom)
        {
            IdEtudiant = unId;
            NomEtudiant = unNom;
            LesRetards = new List<Retard>();
        }

        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public List<Retard> LesRetards { get => lesRetards; set => lesRetards = value; }

        public void AjouterRetard(Retard unRetard)
        {
            lesRetards.Add(unRetard);
        }


        public int GetNbRetardsTotal()
        {
            return lesRetards.Count;
        }

        public int GetNbRetardsExcuses()
        {
            int nbRetardExcuse = 0;

            foreach(Retard r in lesRetards)
            {
                if(r.EstExcuse == true)
                {
                    nbRetardExcuse++;
                }
                
            }

            return nbRetardExcuse;
        }

        public int GetNbRetardsMotif(Motif unMotif)
        {
            int nbRetardsMotif = 0;

            foreach(Retard r in LesRetards)
            {
                if(r.LeMotif == unMotif)
                {
                    nbRetardsMotif++;
                }
                
            }

            return nbRetardsMotif;
            
        }

        public double GetPourcentageRetardsExcuses()
        {
            double pourcentageRetardsExcuse = 0;
            int sommeTotale = 0;
            int nbRetardExcuse = 0;

            sommeTotale = GetNbRetardsTotal();

            foreach(Retard r in lesRetards)
            {
                if(r.EstExcuse == true)
                {
                    nbRetardExcuse++;
                    
                }
                else
                {

                }
            }

            pourcentageRetardsExcuse = Math.Round(Convert.ToDouble((double)(nbRetardExcuse/sommeTotale))*100,2);

            return pourcentageRetardsExcuse;
        }

        public double GetPourcentageRetardsNonExcuses()
        {
            double pourcentage = 0;

            int nbRetardTotale = GetNbRetardsTotal();

            int nbRetardsNonExcuses = 0;

            foreach(Retard r in lesRetards)
            {
                if(r.EstExcuse == false)
                {
                    nbRetardsNonExcuses++;
                }
            }

            pourcentage = Math.Round(Convert.ToDouble((double)(nbRetardsNonExcuses / nbRetardTotale)) * 100, 2);

            return pourcentage;
        }
    }
}

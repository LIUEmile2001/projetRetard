using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class Classe
    {
        private int idClasse;
        private string nomClasse;
        private List<Etudiant> lesEtudiants;

        public Classe(int unId,string unNom)
        {
            IdClasse = unId;
            NomClasse = unNom;
            LesEtudiants = new List<Etudiant>();
        }

        public int IdClasse { get => idClasse; set => idClasse = value; }
        public string NomClasse { get => nomClasse; set => nomClasse = value; }
        public List<Etudiant> LesEtudiants { get => lesEtudiants; set => lesEtudiants = value; }

        public void AjouterEtudiant(Etudiant unEtudiant)
        {
            lesEtudiants.Add(unEtudiant);
        }
    }
}

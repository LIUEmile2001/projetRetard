using System;

namespace ProjetMetier
{
    public class Motif
    {
        private int idMotif;
        private string nomMotif;

        public Motif(int unId,string unNom)
        {
            IdMotif = unId;
            NomMotif = unNom;
        }

        public int IdMotif { get => idMotif; set => idMotif = value; }
        public string NomMotif { get => nomMotif; set => nomMotif = value; }
    }
}

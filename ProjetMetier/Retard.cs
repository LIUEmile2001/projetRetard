using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class Retard
    {
        private string dateRetard;
        private bool estExcuse;
        private int idRetard;
        private Motif leMotif;


        public Retard(int unid,string uneDate,Motif unMotif,bool unExcuse)
        {
            IdRetard = unid;
            DateRetard = uneDate;
            LeMotif = unMotif;
            EstExcuse = unExcuse;
           
        }

        public string DateRetard { get => dateRetard; set => dateRetard = value; }
        public bool EstExcuse { get => estExcuse; set => estExcuse = value; }
        public int IdRetard { get => idRetard; set => idRetard = value; }
        public Motif LeMotif { get => leMotif; set => leMotif = value; }


    }
}

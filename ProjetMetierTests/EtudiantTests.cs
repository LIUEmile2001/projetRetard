using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier.Tests
{
    [TestClass()]
    public class EtudiantTests
    {
        [TestMethod()]
        public void GetNbRetardsTotalTest()
        {

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");


            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);


            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2);

            Assert.AreEqual(2, et1.GetNbRetardsTotal());

        }

        [TestMethod()]
        public void GetNbRetardsExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard3 = new Retard(3, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard4 = new Retard(4, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard5 = new Retard(5, DateTime.Now.ToShortDateString(), motif2, true);


            et1.AjouterRetard(retard1);

            et1.AjouterRetard(retard2);
            et1.AjouterRetard(retard3);

            et1.AjouterRetard(retard4);
            et1.AjouterRetard(retard5);


            Assert.AreEqual(4, et1.GetNbRetardsExcuses());



        }

        [TestMethod()]
        public void GetNbRetardsMotifTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2);

            Assert.AreEqual(1, et1.GetNbRetardsMotif(motif1));


        }

        [TestMethod()]
        public void GetPourcentageRetardsExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");


            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2);


            Assert.AreEqual(0.5, et1.GetPourcentageRetardsExcuses());


        }

        [TestMethod()]
        public void GetPourcentageRetardsNonExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2);

            Assert.AreEqual(1, et1.GetPourcentageRetardsNonExcuses());
        }
    }
}
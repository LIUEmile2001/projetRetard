using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjetMetier;

namespace RetardWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        List<Classe> mesClasses;
        List<Etudiant> mesEtudiants;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mesClasses = new List<Classe>();
            mesEtudiants = new List<Etudiant>();

            Classe sio1 = new Classe(1, "SIO1");
            Classe sio2 = new Classe(2, "SIO2");

            Etudiant et1 = new Etudiant(1, "Enzo");
            Etudiant et2 = new Etudiant(2, "Noa");
            Etudiant et3 = new Etudiant(3, "Lilou");
            Etudiant et4 = new Etudiant(4, "Milo");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif3 = new Motif(3, "Problème transport");
            Motif motif4 = new Motif(4, "RER A");
            Motif motif5 = new Motif(5, "Mariage de mon frère");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard3 = new Retard(3, DateTime.Now.ToShortDateString(), motif3, true);
            Retard retard4 = new Retard(4, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard5 = new Retard(5, DateTime.Now.ToShortDateString(), motif3, false);
            Retard retard6 = new Retard(6, DateTime.Now.ToShortDateString(), motif3, false);
            Retard retard7 = new Retard(7, DateTime.Now.ToShortDateString(), motif3, false);
            Retard retard8 = new Retard(8, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard9 = new Retard(9, DateTime.Now.ToShortDateString(), motif5, true);
            Retard retard10 = new Retard(10, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard11 = new Retard(11, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard12 = new Retard(12, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard13 = new Retard(13, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard14 = new Retard(14, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard15 = new Retard(15, DateTime.Now.ToShortDateString(), motif2, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2); et1.AjouterRetard(retard3);

            et2.AjouterRetard(retard4); et2.AjouterRetard(retard5);

            et3.AjouterRetard(retard6); et3.AjouterRetard(retard7);
            et3.AjouterRetard(retard8); et3.AjouterRetard(retard9);

            et4.AjouterRetard(retard10); et4.AjouterRetard(retard11);
            et4.AjouterRetard(retard12); et4.AjouterRetard(retard13);
            et4.AjouterRetard(retard14); et4.AjouterRetard(retard15);

            sio1.AjouterEtudiant(et1); sio1.AjouterEtudiant(et2);
            sio2.AjouterEtudiant(et3); sio2.AjouterEtudiant(et4);

            mesClasses.Add(sio1); mesClasses.Add(sio2);

            mesEtudiants.Add(et1); mesEtudiants.Add(et2); mesEtudiants.Add(et3); mesEtudiants.Add(et4);
            



            lvClasses.ItemsSource = mesClasses;
            lvEtudiants.ItemsSource = mesEtudiants;

        }

        private void lvClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvClasses.SelectedItem != null)
            {
                lvEtudiants.ItemsSource = (lvClasses.SelectedItem as Classe).LesEtudiants;
            }
        }

        private void lvEtudiants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void lvRetards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

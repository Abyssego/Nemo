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
//Teste72.0
//J'ai résussi
//Yessssssssssssss
//Sa marche réeleeeeement !!!
//Nouveau teste
namespace Nemo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plongeur> lesPlongeurs = new List<Plongeur>();
        List<Plongée> lesPlongées = new List<Plongée>();
        public MainWindow()
        {
            InitializeComponent();
            //modification 11h26 le 20/03/2024

            Plongeur p1 = new Plongeur(1, "Gateau", "Matteo",new NiveauPlonger(2, "peut plonger avec un plongeur de niveau 2 ou plus dans la zone comprise entre 0 et 20m. Par contre, il doit être accompagné par un moniteur dans la zone de 20 à 40m."));
            NiveauPlonger NP1 = new NiveauPlonger(2, "peut plonger avec un plongeur de niveau 2 ou plus dans la zone comprise entre 0 et 20m. Par contre, il doit être accompagné par un moniteur dans la zone de 20 à 40m.");
            lesPlongeurs.Add(p1);
            cboPlongeur.ItemsSource= lesPlongeurs;

            Plongée pl1 = new Plongée();
            pl1.Id = 1;
            pl1.Lieuplong = "Nice";
            pl1.Dateplong = "17-08-2024";
            pl1.IdPlong = 1;

            lesPlongées.Add(pl1);
            cboPlongée.ItemsSource = lesPlongées;




            cboPlongeur.DisplayMemberPath = "PrenomPlongeur";

            cboPlongée.DisplayMemberPath = "Lieuplong";
        }

        private void cboPlongeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboPlongeur.SelectedItem != null)
            {
                Plongeur plongeurSelectionne = (Plongeur)cboPlongeur.SelectedItem;

                // Affichez les informations du plongeur dans les TextBox respectives
                TxtNomPlongeur.Text = plongeurSelectionne.NomPlongeur;
                TxtPrenomPlongeur.Text = plongeurSelectionne.PrenomPlongeur;
                TxtNiveauPlongée.Text = plongeurSelectionne.LeNiveauPlongeur.ToString();
              
            }
            
        }
           
        private void cboPlongée_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboPlongée.SelectedItem !=null)
            {
                Plongée plongéeSelectionne = (Plongée)cboPlongée.SelectedItem;

                TxtLieuxPlongée.Text = plongéeSelectionne.Lieuplong;
                TxtDatePlongée.Text = plongéeSelectionne.Dateplong;
            }
        }
    }
}

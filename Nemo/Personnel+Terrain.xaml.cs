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
        List<Personnel> lePersonnels = new List<Personnel>();
        List<Plongée> lesPlongées = new List<Plongée>();
        public MainWindow()
        {
            InitializeComponent();
            //modification 11h26 le 20/03/2024
            Personnel Perso1 = new Personnel(3, "Dupont", "Jean", "Moniteur", "2", "jean.dupont@gmail.com", "0314526474");
            Plongeur p1 = new Plongeur(1, "Gateau", "Matteo",new NiveauPlonger(2, "peut plonger avec un plongeur de niveau 2 ou plus dans la zone comprise entre 0 et 20m. Par contre, il doit être accompagné par un moniteur dans la zone de 20 à 40m."));
            NiveauPlonger NP1 = new NiveauPlonger(2, "peut plonger avec un plongeur de niveau 2 ou plus dans la zone comprise entre 0 et 20m. Par contre, il doit être accompagné par un moniteur dans la zone de 20 à 40m.");
 
            cboPersonnel.ItemsSource= lePersonnels;

            Plongée pl1 = new Plongée();
            pl1.Id = 1;
            pl1.Lieuplong = "Recif corallien";
            pl1.Dateplong = "2023-05-10";
            pl1.IdPlong = 1;

            lesPlongées.Add(pl1);
            cboPlongée.ItemsSource = lesPlongées;

            lePersonnels.Add(Perso1);



            cboPersonnel.DisplayMemberPath = "Prenom";

            cboPlongée.DisplayMemberPath = "Lieuplong";
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

        private void cboPersonnel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboPersonnel.SelectedItem != null)
            {
                Personnel personnelSelectionne = (Personnel)cboPersonnel.SelectedItem;
                TxtPrenomPersonnel.Text = personnelSelectionne.Prenom;
                TxtNomPersonnel.Text = personnelSelectionne.Nom;
                TxtRolePersonnel.Text = personnelSelectionne.Role;
            }
        }
    }
}

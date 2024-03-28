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

namespace Nemo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plongeur> lesPlongeurs = new List<Plongeur>(); 
        List<Personnel> lesPersonnels = new List<Personnel>();

        public MainWindow()
        {
            InitializeComponent();
            lesPlongeurs.Add(new Plongeur(1, "Terrieur", "Alain", new NiveauPlonger(1, "ce type de plongeur doit être encadré par un moniteur. Il peut participer à toutes les plongées qui ont lieu dans la zone comprise en 0 et 20m de profondeur.", "moniteur", "15m")));
            lesPlongeurs.Add(new Plongeur(2, "Onyme", "Anne", new NiveauPlonger(3, "ce type de plongeur peut plonger avec un plongeur de niveau 2 ou plus dans la zone comprise entre 0 et 20m et avec un plongeur de niveau 3 ou 4 dans la zone comprise entre 20 et 40m.", "niveau 2 ou plus", "25m")));

            /*lesPersonnels.Add(new Personnel(1, "Onyme", "Anne", "moniteur", "02/06/2024", "test"));
            lesPersonnels.Add(new Personnel(2, "Martin", "Sophie", "Assistante", "02/06/2024", "test"));*/

            DtgPlongeur.ItemsSource = lesPlongeurs;
            DtgPersonnel.ItemsSource = lesPersonnels;
        }

        private void btnModifPlongeur_Click(object sender, RoutedEventArgs e)
        {
            int index = DtgPlongeur.SelectedIndex;

            lesPlongeurs[index].LeNiveauPlongeur.NumNiveauPlonger = Convert.ToInt16(txtNiveau.Text);
            lesPlongeurs[index].LeNiveauPlongeur.ProfondeurPlonger = txtProfondeur.Text;
            lesPlongeurs[index].LeNiveauPlongeur.Accompagnant = txtAccompagne.Text;

            DtgPlongeur.Items.Refresh();
        }

        private void btnModifPersonnel_Click(object sender, RoutedEventArgs e)
        {
            int index = DtgPersonnel.SelectedIndex;

            lesPersonnels[index].Nom = txtNomPersonnel.Text;
            lesPersonnels[index].Prenom = txtPNomPersonnel.Text;
            lesPersonnels[index].Role = txtRolePersonnel.Text;

            DtgPersonnel.Items.Refresh();
        }
    }
}

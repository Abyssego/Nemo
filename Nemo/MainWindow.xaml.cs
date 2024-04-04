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
            lesPlongeurs.Add(new Plongeur(1, "Terrieur", "Alain", 2));
            lesPlongeurs.Add(new Plongeur(2, "Onyme", "Anne", 2));

            lesPersonnels.Add(new Personnel(1, "Onyme", "Anne", "moniteur", "02/06/2024", "test"));
            lesPersonnels.Add(new Personnel(2, "Martin", "Sophie", "Assistante", "02/06/2024", "test"));

            var personnel = bdd.SelectPersonnel();

            DtgPlongeur.ItemsSource = lesPlongeurs;
            DtgPersonnel.ItemsSource = personnel;
        }

        private void btnModifPlongeur_Click(object sender, RoutedEventArgs e)
        {
            int index = DtgPlongeur.SelectedIndex;

            // Vérifier si un élément est sélectionné dans la DataGrid
            if (index >= 0 && index < lesPlongeurs.Count)
            {
                Plongeur plongeurSelectionne = lesPlongeurs[index];

                // Accéder à l'instance de NiveauPlonger associée au Plongeur sélectionné
                NiveauPlonger niveauPlonger = plongeurSelectionne.NiveauPlonger;

                // Modifier les propriétés de l'instance de NiveauPlonger
                if (niveauPlonger != null)
                {
                    niveauPlonger.NumNiveauPlonger = Convert.ToInt16(txtNiveau.Text);
                    niveauPlonger.DescriptionNiveauPlonger = txtProfondeur.Text;

                    // Rafraîchir l'affichage
                    DtgPlongeur.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur : NiveauPlonger est null pour ce Plongeur.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un plongeur dans la liste.");
            }
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

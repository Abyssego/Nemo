using MySqlX.XDevAPI;
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
    ///       


    public partial class MainWindow : Window
    {
        List<SitePlonger> lesSitePlonger = new List<SitePlonger>();
        List<NiveauPlonger> lesNiveauPlonger = new List<NiveauPlonger>();
        List<Plonger> lesPlonger = new List<Plonger>();
        List<Plongeur> lesPlongeur = new List<Plongeur>();
        List<ParticipantPlonger> lesParticipantPlonger = new List<ParticipantPlonger>();
        List<Personnel> lesPersonnel = new List<Personnel>();

        public MainWindow()
        {
            InitializeComponent();

            //Initialiser la connexion avec la BDD
            Bdd.Initialize();


            cboPersonelle.ItemsSource = Bdd.SelectPersonnel();

            cboPersonelle.Items.Refresh();

            cboPersonelle.SelectedIndex = 0;

        }

        private void ButtonPersonnelSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Personnel selectedPersonnel = cboPersonelle.SelectedItem as Personnel;
            Bdd.DeletePersonnel(selectedPersonnel.Id);

            lesPersonnel.Clear();
            lesPersonnel = Bdd.SelectPersonnel();

            cboPersonelle.ItemsSource = lesPersonnel;
            cboPersonelle.SelectedItem = 0;
            cboPersonelle.Items.Refresh();

        }

        private void ButtonChangerStatut_Click(object sender, RoutedEventArgs e)
        {
            Personnel selectedPersonnel = cboPersonelle.SelectedItem as Personnel;
            ComboBoxItem selectedStatutItem = cboNouveauStatut.SelectedItem as ComboBoxItem;
            string nouveauStatut = selectedStatutItem.Content.ToString();

            if (selectedPersonnel == null || selectedStatutItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel et un nouveau statut.", "Sélection manquante", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            bool miseAJourReussie = Bdd.UpdatePersonnelStatut(selectedPersonnel.Id, nouveauStatut);

            if (miseAJourReussie)
            {
                MessageBox.Show($"Le statut de {selectedPersonnel.Nom} a été changé en '{nouveauStatut}'.", "Statut mis à jour", MessageBoxButton.OK, MessageBoxImage.Information);
                lesPersonnel = Bdd.SelectPersonnel();
                cboPersonelle.ItemsSource = lesPersonnel;
                cboPersonelle.Items.Refresh();
            }
            else
            {
                MessageBox.Show("La mise à jour du statut a échoué.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}

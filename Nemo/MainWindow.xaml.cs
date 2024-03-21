using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Client> _clients;

        public MainWindow()
        {
            InitializeComponent();
<<<<<<< Updated upstream
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            // Simuler le chargement des données des clients depuis la base de données
            _clients = new ObservableCollection<Client>
            {
                new Client { Nom = "Doe", Prenom = "John", Email = "john.doe@example.com", Telephone = "123456789" },
                new Client { Nom = "Smith", Prenom = "Jane", Email = "jane.smith@example.com", Telephone = "987654321" }
            };

            dataGridClients.ItemsSource = _clients;
        }

        private void AutoriserPret_Click(object sender, RoutedEventArgs e)
        {
            // Logique pour autoriser le prêt de matériel
            if (dataGridClients.SelectedItem is Client selectedClient)
            {
                MessageBox.Show($"Prêt autorisé pour {selectedClient.Prenom} {selectedClient.Nom}");
                // Ici, vous pouvez ajouter la logique pour effectuer l'action d'autorisation dans la base de données
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client pour autoriser le prêt.");
            }
=======
>>>>>>> Stashed changes
        }
    }
}

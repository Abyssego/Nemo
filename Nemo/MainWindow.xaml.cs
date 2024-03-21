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


        }
    }
}

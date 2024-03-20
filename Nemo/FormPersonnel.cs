using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public partial class FormPersonnel
    {
        //private readonly VotreContexteDeBaseDeDonnees _contexte;

        public FormPersonnel()
        {
            //InitializeComponent();
            //_contexte = new VotreContexteDeBaseDeDonnees(); // Assurez-vous de remplacer VotreContexteDeBaseDeDonnees par le nom de votre DbContext
        }

        private void FormPersonnel_Load(object sender, EventArgs e)
        {
            ChargerPersonnel();
        }

        private void ChargerPersonnel()
        {
            //dgvPersonnel.DataSource = _contexte.Personnels.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Logique pour ajouter un nouveau personnel
            /*var nouveauPersonnel = new Personnel
            {
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Role = cmbRole.Text,
                Diplome = txtDiplome.Text,
                Email = txtEmail.Text,
                Telephone = txtTelephone.Text
            };

            _contexte.Personnels.Add(nouveauPersonnel);
            _contexte.SaveChanges();

            ChargerPersonnel();*/
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Logique pour modifier le personnel sélectionné
            /*if (dgvPersonnel.SelectedRows.Count == 1)
            {
                var id = (int)dgvPersonnel.SelectedRows[0].Cells["Id"].Value;
                var personnelAModifier = _contexte.Personnels.Find(id);
                if (personnelAModifier != null)
                {
                    personnelAModifier.Nom = txtNom.Text;
                    personnelAModifier.Prenom = txtPrenom.Text;
                    personnelAModifier.Role = cmbRole.Text;
                    personnelAModifier.Diplome = txtDiplome.Text;
                    personnelAModifier.Email = txtEmail.Text;
                    personnelAModifier.Telephone = txtTelephone.Text;

                    _contexte.SaveChanges();
                    ChargerPersonnel();
                }
            }*/
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Logique pour supprimer le personnel sélectionné
            /*if (dgvPersonnel.SelectedRows.Count == 1)
            {
                var id = (int)dgvPersonnel.SelectedRows[0].Cells["Id"].Value;
                var personnelASupprimer = _contexte.Personnels.Find(id);
                if (personnelASupprimer != null)
                {
                    _contexte.Personnels.Remove(personnelASupprimer);
                    _contexte.SaveChanges();
                    ChargerPersonnel();
                }
            }*/
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            // Logique pour filtrer le personnel en fonction de la recherche
            /*dgvPersonnel.DataSource = _contexte.Personnels
                .Where(p => p.Nom.Contains(txtRecherche.Text) || p.Prenom.Contains(txtRecherche.Text))
                .ToList();*/
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;


namespace GestionSalaraies
{
    public partial class FrmUtilisateurs : Form
    {
        Utilisateurs utilisateurs;
        Roles roles;
        Utilisateur utilisateur;
        bool isAjout;


        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6

        }
        public FrmUtilisateurs()
        {
            InitializeComponent();

        }

        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    cbUtilisateurs.Enabled = (cbUtilisateurs.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = false;
                    break;
                case Contextes.Consultation:
                    btnNouveau.Enabled = true;
                    gbDetailUtilisateur.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = true;
                    txtNom.ReadOnly = true;
                    chkCompteBloque.Enabled = false;
                    cbRoles.Enabled = false;
                    break;
                case Contextes.ModificationInitiale:
                    isAjout = false;
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = true;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    ModifierUtilisateur();
                    ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                    utilisateurs.Save(serialiseur, Properties.Settings.Default.AppData);
                    break;
                case Contextes.AjoutInitial:
                    isAjout = true;
                    txtIdentifiant.Clear();
                    txtMotDePasse.Clear();
                    txtNom.Clear();
                    chkCompteBloque.Checked = false;
                    btnNouveau.Enabled = false;
                    gbDetailUtilisateur.Visible = true;
                    cbUtilisateurs.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtIdentifiant.ReadOnly = false;
                    txtMotDePasse.ReadOnly = false;
                    chkCompteBloque.Enabled = true;
                    txtNom.ReadOnly = false;
                    cbRoles.Enabled = true;
                    ModifierUtilisateur();
                    break;
                case Contextes.AjoutValider:
                    break;
                default:
                    break;
            }

        }

        private void ChargerValeursUtilisateur()
        {
            txtIdentifiant.Text = utilisateur.Identifiant;
            txtMotDePasse.Text = utilisateur.MotDePasse;
            txtNom.Text = utilisateur.Nom;
            chkCompteBloque.Checked = utilisateur.CompteBloque;
            foreach (var item in cbRoles.Items)
            {
                if (item.ToString() == utilisateur.Role.Identifiant)
                {
                    cbRoles.SelectedItem = item;
                    break;
                }
            }
        }
        private void ModifierUtilisateur()
        {

            if (IsValidChamps())
            {
                try
                {
                    utilisateur.Identifiant = txtIdentifiant.Text;
                    utilisateur.MotDePasse = txtMotDePasse.Text;
                    utilisateur.Nom = txtNom.Text;
                    if (chkCompteBloque.Checked == true)
                        utilisateur.CompteBloque = true;
                    else
                        utilisateur.CompteBloque = false;
                }
                catch (Exception e)
                {

                    throw new Exception("Erreur", e);
                }
            }
        }

        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Utilisateur.IsIdentifiantValide(txtIdentifiant.Text))
            {
                valid = false;
                epUtilisateur.SetError(txtIdentifiant, "L'identifiant n'est pas valide");

            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, string.Empty);
            }
            return valid;
        }


        private void ChargerRoles()
        {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur, Properties.Settings.Default.AppData);

            foreach (Role item in roles)
            {
                cbRoles.Items.Add(item.Identifiant);
            }
        }

        private void ChargerUtilisateurs()
        {
            utilisateurs = new Utilisateurs();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Utilisateur item in utilisateurs)
            {
                cbUtilisateurs.Items.Add(item.Identifiant);
            }
        }

        private void FrmUtilisateurs_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
            ChargerRoles();
            GestionnaireContextes(Contextes.Initial);
        }

        private void cbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilisateur = utilisateurs.UtilisateurByMatricule(cbUtilisateurs.Items[cbUtilisateurs.SelectedIndex].ToString());
            ChargerValeursUtilisateur();
            GestionnaireContextes(Contextes.Consultation);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (isAjout)
            {
                GestionnaireContextes(Contextes.AjoutValider);
                Utilisateur utilisateur = new Utilisateur()
                {
                    Identifiant = txtIdentifiant.Text,
                    MotDePasse = txtMotDePasse.Text,
                    Nom = txtNom.Text,
                    CompteBloque = chkCompteBloque.Checked,
                };
                if (cbRoles.SelectedItem != null)
                {
                    utilisateur.Role = roles.RechercherRole(cbRoles.SelectedItem.ToString());
                }
                utilisateurs.Add(utilisateur);
                ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                utilisateurs.Save(serialiseur, Properties.Settings.Default.AppData);
                MessageBox.Show("Le nouvel utilisateur a bien été enregistré", "Nouveau utilisateur",
                    MessageBoxButtons.OK);
            }
            else
            {
                GestionnaireContextes(Contextes.ModificationValider);
                MessageBox.Show("Les modifications ont bien été enregistrés", "Modification utilisateur",
                    MessageBoxButtons.OK);
            }

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
        }
    }
}

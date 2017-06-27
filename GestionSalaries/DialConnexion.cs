using GestionSalaraies.Properties;
using SalariesDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies 
{
    public partial class DialConnexion : Form
    {
        Utilisateurs utilisateurs;
        Utilisateur utilisateur;
        Role role;
        Roles roles;
       
        public DialConnexion()
        {
            InitializeComponent();
            ChargerUtilisateurs();


        }
        private void ChargerUtilisateurs ()
        {
            utilisateurs = new Utilisateurs();
                      
            utilisateurs.Load(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
        }
        #region Gestionnaires Evenements Validation

        /// <summary>
        /// Validation ID Utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdentifiant_Validating(object sender, CancelEventArgs e)
        {
          

            if (IsIdCorrect(txtIdentifiant.Text))
            {
                epUtilisateur.SetError(txtIdentifiant, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtIdentifiant, "Identifiant invalide");
                e.Cancel = true;
            }

        }
        /// <summary>
        /// Interception du traitement de la touche
        /// Assignation de dialogResult Cancel sur Escap
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMDP_Validating(object sender, CancelEventArgs e)
        {
            if (IsMotPasseCorrect(txtMDP.Text))
            {
                epUtilisateur.SetError(txtMDP, String.Empty);
            }
            else
            {
                epUtilisateur.SetError(txtMDP, "Votre mot de passe est incorrect.");
                e.Cancel = true;
            }

        }
        #endregion



        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool IsIdCorrect(string id)
        {
            if (!Utilisateur.IsIdentifiantValide(id)) return false;
                                 
            utilisateur = utilisateurs.UtilisateurByMatricule(id);          
           
            if (utilisateur == null) return false;
            if (utilisateur.Role == null)
            {
                MessageBox.Show("Vous n'êtes pas habilité.", "Habilitation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; 
        }

        private bool IsMotPasseCorrect(string motPasse)
        {
            return(Utilisateur.IsMotPasseValide(motPasse));
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ConnectionResult resultat = utilisateur.Connecter(txtMDP.Text);
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            utilisateurs.Save(serialiseur, Properties.Settings.Default.AppData);

            switch (resultat)
            {
                case ConnectionResult.Connecté:
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    break;
                case ConnectionResult.MotPasseInvalide:
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show(string.Format("Mot de passe erroné, il vous reste {0} essai(s).", 3 - utilisateur.NombreEchecsConsecutifs), "Erreur mot de passe !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case ConnectionResult.CompteBloqué:
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Votre compte est actuellement bloqué, veuillez contacter l'administrateur.", "Compte bloqué",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    break;

            }
                    
        }
    }
}


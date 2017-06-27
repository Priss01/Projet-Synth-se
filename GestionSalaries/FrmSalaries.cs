using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class FrmSalaries : Form
    {
        Salarie salarie;
        Salaries salaries;
        Commercial commercial;
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

        public FrmSalaries()
        {
            InitializeComponent();
        }
        #region Contextes
        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    cbSalarié.Enabled = (cbSalarié.Items.Count > 0);
                    btnNouveauS.Enabled = true;
                    gbDetailSalarié.Visible = false;
                    break;
                case Contextes.Consultation:
                    btnNouveauS.Enabled = true;
                    gbDetailSalarié.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtMatricule.ReadOnly = true;
                    txtNomS.ReadOnly = true;
                    if (salarie is Commercial)
                    {
                        grpBoxCommerciaux.Visible = true;
                    }
                    else
                        grpBoxCommerciaux.Visible = false;
                    break;
                case Contextes.ModificationInitiale:
                    isAjout = false;
                    btnNouveauS.Enabled = false;
                    gbDetailSalarié.Visible = true;
                    cbSalarié.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtMatricule.ReadOnly = true;
                    txtNomS.ReadOnly = false;
                    if (salarie is Commercial)
                    {
                        grpBoxCommerciaux.Visible = true;
                        txtCA.ReadOnly = false;
                        txtTxCom.ReadOnly = false;
                    }
                    else
                        grpBoxCommerciaux.Visible = false;

                    break;
                case Contextes.ModificationAnnuler:
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    ModifierSalarie();
                    ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                    salaries.Save(serialiseur, Properties.Settings.Default.AppData);
                    break;
                case Contextes.AjoutInitial:
                    isAjout = true;
                    txtMatricule.Clear();
                    txtNomS.Clear();
                    btnNouveauS.Enabled = false;
                    gbDetailSalarié.Visible = true;
                    cbSalarié.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    txtMatricule.ReadOnly = false;
                    txtNomS.ReadOnly = false;
                    grpBoxCommerciaux.Visible = false;
                    ModifierSalarie();
                    break;
                case Contextes.AjoutValider:
                    break;
                default:
                    break;
            }

        }
        #endregion
        private void ChargerValeursSalarie()
        {
            txtMatricule.Text = salarie.Matricule;
            txtNomS.Text = salarie.Nom;
            textBPrenom.Text = salarie.Prenom;
            txtDatenaisance.Text = salarie.DateNaissance.ToString();
            txtSalaireB.Text = salarie.SalaireBrut.ToString();
            txtTxCS.Text = salarie.TauxCS.ToString();
            if(salarie is Commercial)
            {
                txtCA.Text = commercial.ChiffreAffaire.ToString();
                txtTxCom.Text = commercial.TauxCS.ToString();
            }
        }

        private void ModifierSalarie()
        {

            if (IsValidChamps())
            {
                try
                {
                    salarie.Matricule = txtMatricule.Text;
                    salarie.Nom = txtNomS.Text;
                    salarie.Prenom = textBPrenom.Text;
                    salarie.DateNaissance = Convert.ToDateTime(txtDatenaisance.Text);
                    salarie.SalaireBrut = Convert.ToInt32(txtSalaireB);
                    salarie.TauxCS = Convert.ToInt32(txtTxCS);
                    if(chkCommercial.Checked ==  true)
                    {
                        commercial.ChiffreAffaire = Convert.ToInt32(txtCA);
                        commercial.TauxCS = Convert.ToInt32(txtTxCS);
                    }


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

            if (!Salarie.IsMatriculeValide(txtMatricule.Text))
            {
                valid = false;
                errorProvider1.SetError(txtMatricule, "Le matricule n'est pas valide");

            }
            else
            {
                errorProvider1.SetError(txtMatricule, string.Empty);
            }
            return valid;
        }
        private void ChargerSalaries()
        {
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries)
            {
                cbSalarié.Items.Add(item.Matricule);
            }
        }
        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }
        private void cbSalarié_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cbSalarié.Items[cbSalarié.SelectedIndex].ToString());
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.Consultation);
        }
       
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (isAjout)
            {
                GestionnaireContextes(Contextes.AjoutValider);
                Salarie salarie = new Salarie()
                {
                    Matricule = txtMatricule.Text,
                    Nom = txtNomS.Text,
                    Prenom = textBPrenom.Text,
                    DateNaissance = Convert.ToDateTime(txtDatenaisance.Text),
                    SalaireBrut = Convert.ToInt32(txtSalaireB.Text),
                    TauxCS = Convert.ToInt32(txtTxCS.Text)
                };

                if (chkCommercial.Checked == true)
                {

                    Commercial commercial = new Commercial()
                    {
                        ChiffreAffaire = Convert.ToInt32(txtCA),
                        Commission = Convert.ToInt32(txtTxCS),
                    };
                }


                salaries.Add(salarie);
                ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                salaries.Save(serialiseur, Properties.Settings.Default.AppData);

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
        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }
        
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
        }

        private void chkCommercial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCommercial.Checked == true)
            {
                grpBoxCommerciaux.Visible = true;
                txtCA.ReadOnly = false;
                txtTxCom.ReadOnly = false;
            }
            else
            {
                grpBoxCommerciaux.Visible = false; 
            }
        }
    }
}

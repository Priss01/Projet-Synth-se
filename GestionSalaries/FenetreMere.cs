using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies
{
    public partial class FenetreMere : Form
    {
        public FenetreMere()
        {
            InitializeComponent();
        }

        private void _ClickGU(object sender, EventArgs e)
        {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
            frmUtilisateurs.MdiParent = this;
            frmUtilisateurs.Show();
        }

        private void Click_GS(object sender, EventArgs e)
        {
            FrmSalaries frmSalaries = new FrmSalaries();
            frmSalaries.MdiParent = this;
            frmSalaries.Show();
        }

        private void FenetreMere_Load(object sender, EventArgs e)
        {
            DialConnexion connexion = new DialConnexion();
            //DialogResult resultat = connexion.ShowDialog();
            DialogResult resultat = DialogResult.OK;

            switch(resultat)
            {
                case DialogResult.Cancel:
                    {
                        Close();
                    }
                    break;

                case DialogResult.OK:
                    {
                        MessageBox.Show("Vous êtes connecté.", "Connection",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    break;
            }
        }
    }
}

using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    public partial class Authentification : Form
    {
        private readonly BindingSource bdg = new BindingSource();
        //private List<lesutilisateurs> lesprofils = new List<lesutilisateurs>();
        private readonly FrmMediatekController controller;
        public Authentification()
        {
            InitializeComponent();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text;
            string pwd = txtpwd.Text;
            Utilisateur admin = new Utilisateur(login, pwd);
            //lesprofils = controller.verifadmin(admin);
            //if (lesprofils != null)
            //{
            //    bdg.DataSource = lesprofils;
            //    dgvuti.DataSource = bdg;

            //}
            if (txtlogin.Text == "" || txtpwd.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs ");

            }
            else
            {
                if (txtlogin.Text == "admin" && txtpwd.Text == "pwd")
                {
                    FrmMediatek frm = new FrmMediatek();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur d'authentification ");
                }
            }
        }
    }
}

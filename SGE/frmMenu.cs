using Entity;
using SGE.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE
{
    public partial class frmMenu : Form
    {
        public UsuarioInfo voUsuario;
        public frmMenu(UsuarioInfo pUsuario)
        {
            InitializeComponent();
            voUsuario = pUsuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtNome.Text = voUsuario.Nome;
            txtUsuario.Text = voUsuario.Usuario;
            lblBemVindo.Text = voUsuario.Usuario;
            txtEmail.Text = voUsuario.Email;
            picGreen.Visible = true;
            picRed.Visible = false;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }
    }
}

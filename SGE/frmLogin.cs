using Entity;
using Facade;
using Plural.Seguranca;
using System.Runtime.Intrinsics.Arm;

namespace SGE
{
    public partial class frmLogin : Form
    {
        public UsuarioInfo voUsuario = new UsuarioInfo();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {


            string voSenhaCripto = string.Empty;

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("FAVOR INFORMAR USUÁRIO E SENHA.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            voSenhaCripto = Criptografia.CriptografarMD5(txtSenha.Text);


            voUsuario = UtilFacade.ValidarUsuario(txtUsuario.Text, voSenhaCripto);


            if (voUsuario.Id == 0)
            {
                MessageBox.Show("USUÁRIO OU SENHA INCORRETOS.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }
            else
            {
                frmMenu oMenu = new frmMenu(voUsuario);
                this.Hide();
                oMenu.ShowDialog();
                this.Close();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Enter)
                txtSenha.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Enter)
                Logar();
        }
    }
}
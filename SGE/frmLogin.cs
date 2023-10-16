using Plural.Seguranca;
using System.Runtime.Intrinsics.Arm;

namespace SGE
{
    public partial class frmLogin : Form
    {
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
            int retornoUser = 0;

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("FAVOR INFORMAR USUÁRIO E SENHA.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            voSenhaCripto = Criptografia.CriptografarMD5(txtSenha.Text);


            voUsuario = UtilFacade.ValidarUsuario(int.Parse(txtUsuario.Text), voSenhaCripto);


            if (voUsuario.Codigo == 0)
            {
                MessageBox.Show("USUÁRIO OU SENHA INCORRETOS.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }
            else
            {
                if (Adm)
                {

                    if (voUsuario.Administrador == 1)
                    {
                        frmCadUsuario otela = new frmCadUsuario(voUsuario);
                        this.Hide();
                        otela.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("USUÁRIO SEM PERMISSÃO ADMINISTRADOR.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else if (AbrirMenu)
                {
                    if (oMonitorWebService)
                    {
                        //Só Retorna o Usuário para o monitor WebService.
                        Close();
                    }
                    else
                    {
                        frmMenu oMenu = new frmMenu(voUsuario);
                        this.Hide();
                        oMenu.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

            }
        }

    }
}
using BUS.Clientes;
using Entity.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            cboUF.Text = "";
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtRG.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botao consultar Cep
            try
            {
                string cep = txtCEP.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cboUF.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }
        private bool verificarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha o nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show("Preencha o RG", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Preencha o CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Preencha o email", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Preencha o telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("Preencha o celular", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Preencha o endereço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Preencha o numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show("Preencha o complemento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Preencha o bairro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Preencha a cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(cboUF.Text))
            {
                MessageBox.Show("Preencha o estado (UF)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Botao pesquisar
                string nome = txtBuscar.Text;
                //ClienteDAO dao = new ClienteDAO();

                //dgvClientes.DataSource = dao.BuscarClientePorNome(nome);

                if (dgvClientes.Rows.Count == 0)
                {
                    //Recarregar o datagridview
                    //dgvClientes.DataSource = dao.listarClientes();
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                var op = MessageBox.Show("Tem certeza que deseja salvar os dados preenchidos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (op == DialogResult.Yes)
                {
                    // 1 passo - Receber os dados dentro do objeto modelo de cliente
                    ClienteInfo obj = new ClienteInfo();


                    obj.nome = txtNome.Text;
                    obj.rg = txtRG.Text.Replace(",", ".");
                    obj.cpf = txtCPF.Text.Replace(",", ".");
                    obj.email = txtEmail.Text;
                    obj.telefone = txtTelefone.Text;
                    obj.celular = txtCelular.Text;
                    obj.cep = txtCEP.Text;
                    obj.endereco = txtEndereco.Text;
                    obj.numero = int.Parse(txtNumero.Text);
                    obj.complemento = txtComplemento.Text;
                    obj.bairro = txtBairro.Text;
                    obj.cidade = txtCidade.Text;
                    obj.estado = cboUF.Text;

                    //2 passo - Criar um objeto da classe ClienteDAO e chamar o metodo cadastraCliente
                    //ClienteDAO dao = new ClienteDAO();
                    //dao.cadastrarCliente(obj);

                    //recarregar o datagridview
                    //dgvClientes.DataSource = dao.listarClientes();
                    LimparCampos();
                    gbDados.Enabled = false;
                    gbEndereco.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnNovo.Enabled = true;
                }

            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada            
            txtNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvClientes.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvClientes.CurrentRow.Cells[12].Value.ToString();
            cboUF.Text = dgvClientes.CurrentRow.Cells[13].Value.ToString();

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            gbDados.Enabled = true;
            gbEndereco.Enabled = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBuscar.Text + "%";

            dgvClientes.DataSource = ClienteBUS.ListarClientesPorNome(nome);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

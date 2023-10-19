using BUS.Clientes;
using DAL.Clientes;
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

namespace SGE.Clientes;

public partial class frmClientes : Form
{
    List<ClienteInfo> lstClientes;
    ClienteInfo voCliente;
    public frmClientes()
    {
        InitializeComponent();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
        LimparCampos();
        txtNome.Focus();
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
        ConsultarCEP(txtCEP.Text);
    }
    private void ConsultarCEP(string pCEP)
    {
        //Botao consultar Cep
        try
        {
            string cep = pCEP;
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

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (verificarCampos())
        {
            var op = MessageBox.Show("Tem certeza que deseja salvar os dados preenchidos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {

                voCliente = ClienteBUS.ObterCliente(txtCPF.Text);

                if (voCliente.Id != 0)
                {
                    voCliente.Nome = txtNome.Text;
                    voCliente.RG = txtRG.Text.Replace(",", ".");
                    voCliente.CPF = txtCPF.Text.Replace(",", ".");
                    voCliente.Email = txtEmail.Text;
                    voCliente.Telefone = txtTelefone.Text;
                    voCliente.Celular = txtCelular.Text;
                    voCliente.CEP = txtCEP.Text;
                    voCliente.Endereco = txtEndereco.Text;
                    voCliente.Numero = int.Parse(txtNumero.Text);
                    voCliente.Complemento = txtComplemento.Text;
                    voCliente.Bairro = txtBairro.Text;
                    voCliente.Cidade = txtCidade.Text;
                    voCliente.Estado = cboUF.Text;

                    ClienteBUS.AtualizarCliente(voCliente);

                    MessageBox.Show("Cliente atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClienteInfo obj = new ClienteInfo();

                    obj.Nome = txtNome.Text;
                    obj.RG = txtRG.Text.Replace(",", ".");
                    obj.CPF = txtCPF.Text.Replace(",", ".");
                    obj.Email = txtEmail.Text;
                    obj.Telefone = txtTelefone.Text;
                    obj.Celular = txtCelular.Text;
                    obj.CEP = txtCEP.Text;
                    obj.Endereco = txtEndereco.Text;
                    obj.Numero = !string.IsNullOrEmpty(txtNumero.Text) ? int.Parse(txtNumero.Text): 0;
                    obj.Complemento = txtComplemento.Text;
                    obj.Bairro = txtBairro.Text;
                    obj.Cidade = txtCidade.Text;
                    obj.Estado = cboUF.Text;

                    ClienteBUS.CadastrarCliente(obj);

                    MessageBox.Show("Cliente cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                CarregarGrid();

                LimparCampos();
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

    }

    private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
        string nome = "%" + txtBuscar.Text + "%";

        lstClientes = ClienteBUS.ListarClientesPorNome(nome);

        if (lstClientes.Count > 0)
            dgvClientes.DataSource = lstClientes;
    }

    private void frmClientes_Load(object sender, EventArgs e)
    {
        CarregarGrid();
    }

    private void CarregarGrid()
    {
        lstClientes = ClienteBUS.ListarClientes();
        dgvClientes.DataSource = lstClientes;
    }

    private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ClienteInfo objCliente = new ClienteInfo();
        objCliente = (ClienteInfo)dgvClientes.SelectedRows[0].DataBoundItem;

        if (MessageBox.Show("Deseja realmente EXCLUIR o cliente " + objCliente.Nome + "?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {

            ClienteBUS.ExcluirCliente(objCliente);

            MessageBox.Show("Cliente excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarGrid();
        }

    }

    private void txtCEP_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            ConsultarCEP(txtCEP.Text);
    }
}

namespace SGE.Clientes
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbDados = new GroupBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            txtCPF = new MaskedTextBox();
            label5 = new Label();
            txtRG = new MaskedTextBox();
            label6 = new Label();
            txtCelular = new MaskedTextBox();
            label3 = new Label();
            txtTelefone = new MaskedTextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            gbEndereco = new GroupBox();
            btnBuscar = new Button();
            cboUF = new ComboBox();
            label13 = new Label();
            txtCidade = new TextBox();
            label12 = new Label();
            txtNumero = new TextBox();
            label11 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtComplemento = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtEndereco = new TextBox();
            txtCEP = new MaskedTextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            dgvClientes = new DataGridView();
            MenuGrid = new ContextMenuStrip(components);
            excluirClienteToolStripMenuItem = new ToolStripMenuItem();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            gbDados.SuspendLayout();
            gbEndereco.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            MenuGrid.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbDados.Controls.Add(btnNovo);
            gbDados.Controls.Add(btnSalvar);
            gbDados.Controls.Add(txtCPF);
            gbDados.Controls.Add(label5);
            gbDados.Controls.Add(txtRG);
            gbDados.Controls.Add(label6);
            gbDados.Controls.Add(txtCelular);
            gbDados.Controls.Add(label3);
            gbDados.Controls.Add(txtTelefone);
            gbDados.Controls.Add(label2);
            gbDados.Controls.Add(txtEmail);
            gbDados.Controls.Add(label1);
            gbDados.Controls.Add(lblNome);
            gbDados.Controls.Add(txtNome);
            gbDados.Location = new Point(12, 77);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(357, 226);
            gbDados.TabIndex = 11;
            gbDados.TabStop = false;
            gbDados.Text = "Dados Pessoais";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(0, 31, 70);
            btnNovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(98, 166);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(85, 38);
            btnNovo.TabIndex = 31;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 31, 70);
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(217, 166);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 38);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(253, 125);
            txtCPF.Mask = "###,###,###-##";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(95, 23);
            txtCPF.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 31, 70);
            label5.Location = new Point(217, 128);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "CPF:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(253, 96);
            txtRG.Mask = "##,###,###-#";
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(95, 23);
            txtRG.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 31, 70);
            label6.Location = new Point(222, 99);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 11;
            label6.Text = "RG:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(69, 125);
            txtCelular.Mask = "(99) 00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(94, 23);
            txtCelular.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 31, 70);
            label3.Location = new Point(17, 128);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Celular:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(69, 96);
            txtTelefone.Mask = "(99) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(94, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 31, 70);
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 23);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 31, 70);
            label1.Location = new Point(20, 70);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "E-mail:";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(0, 31, 70);
            lblNome.Location = new Point(20, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(279, 23);
            txtNome.TabIndex = 1;
            // 
            // gbEndereco
            // 
            gbEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEndereco.Controls.Add(btnBuscar);
            gbEndereco.Controls.Add(cboUF);
            gbEndereco.Controls.Add(label13);
            gbEndereco.Controls.Add(txtCidade);
            gbEndereco.Controls.Add(label12);
            gbEndereco.Controls.Add(txtNumero);
            gbEndereco.Controls.Add(label11);
            gbEndereco.Controls.Add(txtBairro);
            gbEndereco.Controls.Add(label10);
            gbEndereco.Controls.Add(txtComplemento);
            gbEndereco.Controls.Add(label8);
            gbEndereco.Controls.Add(label9);
            gbEndereco.Controls.Add(txtEndereco);
            gbEndereco.Controls.Add(txtCEP);
            gbEndereco.Controls.Add(label7);
            gbEndereco.Location = new Point(387, 77);
            gbEndereco.Name = "gbEndereco";
            gbEndereco.Size = new Size(358, 226);
            gbEndereco.TabIndex = 12;
            gbEndereco.TabStop = false;
            gbEndereco.Text = "Endereço";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 31, 70);
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(236, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 38);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cboUF
            // 
            cboUF.FormattingEnabled = true;
            cboUF.Location = new Point(270, 152);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(61, 23);
            cboUF.TabIndex = 13;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 31, 70);
            label13.Location = new Point(240, 155);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 27;
            label13.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(96, 186);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(117, 23);
            txtCidade.TabIndex = 12;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 31, 70);
            label12.Location = new Point(44, 189);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 25;
            label12.Text = "Cidade:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 157);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(117, 23);
            txtNumero.TabIndex = 9;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 31, 70);
            label11.Location = new Point(36, 160);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 23;
            label11.Text = "Número:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(96, 126);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(117, 23);
            txtBairro.TabIndex = 10;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 31, 70);
            label10.Location = new Point(49, 129);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 21;
            label10.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(96, 96);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(117, 23);
            txtComplemento.TabIndex = 8;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 31, 70);
            label8.Location = new Point(4, 99);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 19;
            label8.Text = "Complemento:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 31, 70);
            label9.Location = new Point(31, 71);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 18;
            label9.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(96, 68);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(235, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(96, 40);
            txtCEP.Mask = "#####-###";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(95, 23);
            txtCEP.TabIndex = 7;
            txtCEP.KeyDown += txtCEP_KeyDown;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 31, 70);
            label7.Location = new Point(60, 43);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 15;
            label7.Text = "CEP:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(dgvClientes);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Location = new Point(12, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 322);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 31, 70);
            label14.Location = new Point(168, 22);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 33;
            label14.Text = "Buscar:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ContextMenuStrip = MenuGrid;
            dgvClientes.Location = new Point(8, 52);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(719, 261);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // MenuGrid
            // 
            MenuGrid.Items.AddRange(new ToolStripItem[] { excluirClienteToolStripMenuItem });
            MenuGrid.Name = "MenuGrid";
            MenuGrid.Size = new Size(150, 26);
            // 
            // excluirClienteToolStripMenuItem
            // 
            excluirClienteToolStripMenuItem.Name = "excluirClienteToolStripMenuItem";
            excluirClienteToolStripMenuItem.Size = new Size(149, 22);
            excluirClienteToolStripMenuItem.Text = "Excluir Cliente";
            excluirClienteToolStripMenuItem.Click += excluirClienteToolStripMenuItem_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(222, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 32;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 71);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 31, 70);
            label4.Location = new Point(192, 9);
            label4.Name = "label4";
            label4.Size = new Size(386, 40);
            label4.TabIndex = 12;
            label4.Text = "Gerenciamento de Clientes";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 31, 70);
            panel4.Location = new Point(-211, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(1718, 13);
            panel4.TabIndex = 11;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 634);
            Controls.Add(groupBox1);
            Controls.Add(gbDados);
            Controls.Add(gbEndereco);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmClientes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Clientes";
            Load += frmClientes_Load;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            gbEndereco.ResumeLayout(false);
            gbEndereco.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            MenuGrid.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbDados;
        private TextBox txtNome;
        private GroupBox gbEndereco;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private Label lblNome;
        private MaskedTextBox txtCPF;
        private Label label5;
        private MaskedTextBox txtRG;
        private Label label6;
        private MaskedTextBox txtCelular;
        private Label label3;
        private MaskedTextBox txtTelefone;
        private TextBox txtComplemento;
        private Label label8;
        private Label label9;
        private TextBox txtEndereco;
        private MaskedTextBox txtCEP;
        private Label label7;
        private ComboBox cboUF;
        private Label label13;
        private TextBox txtCidade;
        private Label label12;
        private TextBox txtNumero;
        private Label label11;
        private TextBox txtBairro;
        private Label label10;
        private GroupBox groupBox1;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnBuscar;
        private Label label14;
        private DataGridView dgvClientes;
        private TextBox txtBuscar;
        private ContextMenuStrip MenuGrid;
        private ToolStripMenuItem excluirClienteToolStripMenuItem;
        private Panel panel1;
        private Label label4;
        private Panel panel4;
    }
}
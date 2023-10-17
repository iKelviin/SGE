namespace SGE
{
    partial class frmMenu
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
            panel1 = new Panel();
            picGreen = new PictureBox();
            txtEmail = new Label();
            lblEmail = new Label();
            txtNome = new Label();
            lblNome = new Label();
            txtUsuario = new Label();
            lblUsuario = new Label();
            picRed = new PictureBox();
            menuStrip1 = new MenuStrip();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRed).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picGreen);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(picRed);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 36);
            panel1.TabIndex = 0;
            // 
            // picGreen
            // 
            picGreen.Image = Properties.Resources.green;
            picGreen.Location = new Point(6, 6);
            picGreen.Name = "picGreen";
            picGreen.Size = new Size(24, 24);
            picGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            picGreen.TabIndex = 2;
            picGreen.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(0, 31, 70);
            txtEmail.Location = new Point(609, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(22, 15);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "---";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(0, 31, 70);
            lblEmail.Location = new Point(572, 9);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(0, 31, 70);
            txtNome.Location = new Point(319, 9);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(22, 15);
            txtNome.TabIndex = 4;
            txtNome.Text = "---";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(0, 31, 70);
            lblNome.Location = new Point(278, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(0, 31, 70);
            txtUsuario.Location = new Point(98, 9);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(22, 15);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "---";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(0, 31, 70);
            lblUsuario.Location = new Point(49, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // picRed
            // 
            picRed.Image = Properties.Resources.red;
            picRed.Location = new Point(6, 6);
            picRed.Name = "picRed";
            picRed.Size = new Size(24, 24);
            picRed.SizeMode = PictureBoxSizeMode.StretchImage;
            picRed.TabIndex = 0;
            picRed.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem, clientesToolStripMenuItem, produtosToolStripMenuItem, clientesToolStripMenuItem1, fornecedoresToolStripMenuItem, estoqueToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(12, 20);
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(61, 20);
            clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(90, 20);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão Empresarial";
            Load += frmMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRed).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtNome;
        private Label lblNome;
        private Label txtUsuario;
        private Label lblUsuario;
        private PictureBox picRed;
        private Label txtEmail;
        private Label lblEmail;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private PictureBox picGreen;

        public ToolStripItemClickedEventHandler Menus_ItemClicked { get; private set; }
    }
}
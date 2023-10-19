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
            clientesToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lblBemVindo = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRed).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Location = new Point(0, 519);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 36);
            panel1.TabIndex = 0;
            // 
            // picGreen
            // 
            picGreen.Image = Properties.Resources.green;
            picGreen.Location = new Point(16, 6);
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
            txtEmail.Location = new Point(674, 9);
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
            lblEmail.Location = new Point(637, 9);
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
            txtNome.Location = new Point(334, 9);
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
            lblNome.Location = new Point(293, 9);
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
            txtUsuario.Location = new Point(113, 9);
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
            lblUsuario.Location = new Point(64, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // picRed
            // 
            picRed.Image = Properties.Resources.red;
            picRed.Location = new Point(16, 6);
            picRed.Name = "picRed";
            picRed.Size = new Size(24, 24);
            picRed.SizeMode = PictureBoxSizeMode.StretchImage;
            picRed.TabIndex = 0;
            picRed.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(25, 25);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionáriosToolStripMenuItem, fornecedoresToolStripMenuItem, produtosToolStripMenuItem, vendasToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 555);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.AutoSize = false;
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clientesToolStripMenuItem.Image = Properties.Resources.team;
            clientesToolStripMenuItem.ImageTransparentColor = Color.White;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(150, 85);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.AutoSize = false;
            funcionáriosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            funcionáriosToolStripMenuItem.Image = Properties.Resources.customer_service;
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(150, 85);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.AutoSize = false;
            fornecedoresToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fornecedoresToolStripMenuItem.Image = Properties.Resources.truck;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(150, 85);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.AutoSize = false;
            produtosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            produtosToolStripMenuItem.Image = Properties.Resources.brand_identity;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(150, 85);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.AutoSize = false;
            vendasToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vendasToolStripMenuItem.Image = Properties.Resources.money;
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(150, 85);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.AutoSize = false;
            configuraçõesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            configuraçõesToolStripMenuItem.Image = Properties.Resources.configuration;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(150, 85);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblBemVindo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(156, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 555);
            panel2.TabIndex = 3;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBemVindo.ForeColor = Color.Black;
            lblBemVindo.Location = new Point(297, 472);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(34, 38);
            lblBemVindo.TabIndex = 13;
            lblBemVindo.Text = "#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 472);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 12;
            label2.Text = "Seja Bem-Vindo,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 31, 70);
            label1.Location = new Point(230, 118);
            label1.Name = "label1";
            label1.Size = new Size(387, 86);
            label1.TabIndex = 11;
            label1.Text = "Empresarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 31, 70);
            label4.Location = new Point(49, 32);
            label4.Name = "label4";
            label4.Size = new Size(768, 86);
            label4.TabIndex = 10;
            label4.Text = "SGE - Sistema de Gestão";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 31, 70);
            panel3.Location = new Point(-3, -8);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 566);
            panel3.TabIndex = 0;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 555);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private PictureBox picGreen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label1;
        private Label lblBemVindo;
        private Label label2;

        public ToolStripItemClickedEventHandler Menus_ItemClicked { get; private set; }
    }
}
using System.Windows.Media.Media3D;

namespace QueFome
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            btnConfiguracao = new FontAwesome.Sharp.IconButton();
            btnMarketing = new FontAwesome.Sharp.IconButton();
            btnEntregas = new FontAwesome.Sharp.IconButton();
            btnProdutos = new FontAwesome.Sharp.IconButton();
            btnVendas = new FontAwesome.Sharp.IconButton();
            btnEstatisticas = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            lblHora = new Label();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            lblData = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnConfiguracao);
            panelMenu.Controls.Add(btnMarketing);
            panelMenu.Controls.Add(btnEntregas);
            panelMenu.Controls.Add(btnProdutos);
            panelMenu.Controls.Add(btnVendas);
            panelMenu.Controls.Add(btnEstatisticas);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 597);
            panelMenu.TabIndex = 0;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.Dock = DockStyle.Top;
            btnConfiguracao.FlatAppearance.BorderSize = 0;
            btnConfiguracao.FlatStyle = FlatStyle.Flat;
            btnConfiguracao.ForeColor = Color.Gainsboro;
            btnConfiguracao.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnConfiguracao.IconColor = Color.Gainsboro;
            btnConfiguracao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracao.IconSize = 32;
            btnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.Location = new Point(0, 440);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Padding = new Padding(10, 0, 20, 0);
            btnConfiguracao.Size = new Size(220, 60);
            btnConfiguracao.TabIndex = 6;
            btnConfiguracao.Text = "Configurações";
            btnConfiguracao.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracao.UseVisualStyleBackColor = true;
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // btnMarketing
            // 
            btnMarketing.Dock = DockStyle.Top;
            btnMarketing.FlatAppearance.BorderSize = 0;
            btnMarketing.FlatStyle = FlatStyle.Flat;
            btnMarketing.ForeColor = Color.Gainsboro;
            btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            btnMarketing.IconColor = Color.Gainsboro;
            btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarketing.IconSize = 32;
            btnMarketing.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarketing.Location = new Point(0, 380);
            btnMarketing.Name = "btnMarketing";
            btnMarketing.Padding = new Padding(10, 0, 20, 0);
            btnMarketing.Size = new Size(220, 60);
            btnMarketing.TabIndex = 5;
            btnMarketing.Text = "Marketing";
            btnMarketing.TextAlign = ContentAlignment.MiddleLeft;
            btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMarketing.UseVisualStyleBackColor = true;
            btnMarketing.Click += btnMarketing_Click;
            // 
            // btnEntregas
            // 
            btnEntregas.Dock = DockStyle.Top;
            btnEntregas.FlatAppearance.BorderSize = 0;
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.ForeColor = Color.Gainsboro;
            btnEntregas.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btnEntregas.IconColor = Color.Gainsboro;
            btnEntregas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEntregas.IconSize = 32;
            btnEntregas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntregas.Location = new Point(0, 320);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Padding = new Padding(10, 0, 20, 0);
            btnEntregas.Size = new Size(220, 60);
            btnEntregas.TabIndex = 4;
            btnEntregas.Text = "Entregas";
            btnEntregas.TextAlign = ContentAlignment.MiddleLeft;
            btnEntregas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntregas.UseVisualStyleBackColor = true;
            btnEntregas.Click += btnEntregas_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Dock = DockStyle.Top;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.ForeColor = Color.Gainsboro;
            btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnProdutos.IconColor = Color.Gainsboro;
            btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProdutos.IconSize = 32;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(0, 260);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(10, 0, 20, 0);
            btnProdutos.Size = new Size(220, 60);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Dock = DockStyle.Top;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.ForeColor = Color.Gainsboro;
            btnVendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnVendas.IconColor = Color.Gainsboro;
            btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVendas.IconSize = 32;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(0, 200);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(10, 0, 20, 0);
            btnVendas.Size = new Size(220, 60);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Vendas";
            btnVendas.TextAlign = ContentAlignment.MiddleLeft;
            btnVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.Dock = DockStyle.Top;
            btnEstatisticas.FlatAppearance.BorderSize = 0;
            btnEstatisticas.FlatStyle = FlatStyle.Flat;
            btnEstatisticas.ForeColor = Color.Gainsboro;
            btnEstatisticas.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnEstatisticas.IconColor = Color.Gainsboro;
            btnEstatisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstatisticas.IconSize = 32;
            btnEstatisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstatisticas.Location = new Point(0, 140);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Padding = new Padding(10, 0, 20, 0);
            btnEstatisticas.Size = new Size(220, 60);
            btnEstatisticas.TabIndex = 1;
            btnEstatisticas.Text = "Estatísticas";
            btnEstatisticas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstatisticas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstatisticas.UseVisualStyleBackColor = true;
            btnEstatisticas.Click += btnEstatisticas_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.logo_Que_Fome;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(217, 131);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Black;
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(pictureBox2);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblHora);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(962, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(482, 47);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 6;
            label1.Text = "Mcdonald's - North Shop. Barretos (nsb)";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.image_10_removebg_preview;
            pictureBox2.Location = new Point(762, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 16;
            btnMinimize.Location = new Point(882, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(18, 16);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.Gainsboro;
            lblHora.Location = new Point(855, 47);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(104, 25);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:MM:SS";
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(906, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(23, 20);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 15;
            btnExit.Location = new Point(935, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(15, 16);
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(63, 23);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(50, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.ForeColor = Color.Red;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.Red;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(17, 12);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.White;
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(962, 8);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.Black;
            panelDesktop.Controls.Add(lblData);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 83);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(962, 514);
            panelDesktop.TabIndex = 3;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.None;
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.ForeColor = Color.Silver;
            lblData.Location = new Point(304, 312);
            lblData.Name = "lblData";
            lblData.Size = new Size(422, 50);
            lblData.TabIndex = 3;
            lblData.Text = "dd/mm/aaaa hh:mm:ss";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_Que_Fome;
            pictureBox1.Location = new Point(304, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 597);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Resize += Form1_Resize;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnConfiguracao;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnEntregas;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private FontAwesome.Sharp.IconButton btnVendas;
        private FontAwesome.Sharp.IconButton btnEstatisticas;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private System.Windows.Forms.Timer timer1;
        private Label lblHora;
        private Label lblData;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
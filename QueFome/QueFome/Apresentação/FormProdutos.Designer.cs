namespace QueFome
{
    partial class FormProdutos
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
            btn_adicionar = new Button();
            bt_excluir = new Button();
            lv_produto = new ListView();
            col_id = new ColumnHeader();
            col_grupo = new ColumnHeader();
            col_nome = new ColumnHeader();
            col_preco = new ColumnHeader();
            txt_id = new TextBox();
            txt_grupo = new TextBox();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_procurar = new TextBox();
            icon_pesquisar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)icon_pesquisar).BeginInit();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = Color.LawnGreen;
            btn_adicionar.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicionar.ForeColor = Color.Black;
            btn_adicionar.Location = new Point(152, 516);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(157, 50);
            btn_adicionar.TabIndex = 1;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // bt_excluir
            // 
            bt_excluir.BackColor = Color.Red;
            bt_excluir.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bt_excluir.ForeColor = Color.Black;
            bt_excluir.Location = new Point(574, 516);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(156, 50);
            bt_excluir.TabIndex = 2;
            bt_excluir.Text = "Excluir";
            bt_excluir.UseVisualStyleBackColor = false;
            bt_excluir.Click += bt_excluir_Click;
            // 
            // lv_produto
            // 
            lv_produto.Columns.AddRange(new ColumnHeader[] { col_id, col_grupo, col_nome, col_preco });
            lv_produto.FullRowSelect = true;
            lv_produto.GridLines = true;
            lv_produto.Location = new Point(136, 119);
            lv_produto.Name = "lv_produto";
            lv_produto.Size = new Size(613, 305);
            lv_produto.TabIndex = 3;
            lv_produto.UseCompatibleStateImageBehavior = false;
            lv_produto.View = View.Details;
            lv_produto.SelectedIndexChanged += lv_produto_SelectedIndexChanged;
            // 
            // col_id
            // 
            col_id.Text = "ID";
            // 
            // col_grupo
            // 
            col_grupo.Text = "Grupo";
            col_grupo.Width = 150;
            // 
            // col_nome
            // 
            col_nome.Text = "Nome";
            col_nome.Width = 300;
            // 
            // col_preco
            // 
            col_preco.Text = "Preço";
            col_preco.Width = 100;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(136, 450);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(58, 27);
            txt_id.TabIndex = 4;
            // 
            // txt_grupo
            // 
            txt_grupo.Location = new Point(200, 450);
            txt_grupo.Name = "txt_grupo";
            txt_grupo.Size = new Size(148, 27);
            txt_grupo.TabIndex = 5;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(356, 450);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(288, 27);
            txt_nome.TabIndex = 6;
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(650, 450);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(99, 27);
            txt_preco.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(136, 427);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(200, 427);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(356, 427);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(673, 427);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Preço";
            // 
            // txt_procurar
            // 
            txt_procurar.Cursor = Cursors.IBeam;
            txt_procurar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_procurar.ForeColor = Color.Black;
            txt_procurar.Location = new Point(136, 58);
            txt_procurar.Name = "txt_procurar";
            txt_procurar.PlaceholderText = "   Pesquisar";
            txt_procurar.Size = new Size(563, 38);
            txt_procurar.TabIndex = 12;
            // 
            // icon_pesquisar
            // 
            icon_pesquisar.BackColor = Color.White;
            icon_pesquisar.ForeColor = Color.Red;
            icon_pesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icon_pesquisar.IconColor = Color.Red;
            icon_pesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_pesquisar.IconSize = 38;
            icon_pesquisar.Location = new Point(700, 58);
            icon_pesquisar.Name = "icon_pesquisar";
            icon_pesquisar.Size = new Size(49, 38);
            icon_pesquisar.TabIndex = 13;
            icon_pesquisar.TabStop = false;
            icon_pesquisar.Click += icon_pesquisar_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1092, 630);
            Controls.Add(icon_pesquisar);
            Controls.Add(txt_procurar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_preco);
            Controls.Add(txt_nome);
            Controls.Add(txt_grupo);
            Controls.Add(txt_id);
            Controls.Add(lv_produto);
            Controls.Add(bt_excluir);
            Controls.Add(btn_adicionar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Name = "FormProdutos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)icon_pesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_adicionar;
        private Button bt_excluir;
        private ListView lv_produto;
        private ColumnHeader col_id;
        private ColumnHeader col_grupo;
        private ColumnHeader col_nome;
        private ColumnHeader col_preco;
        private TextBox txt_id;
        private TextBox txt_grupo;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_procurar;
        private FontAwesome.Sharp.IconPictureBox icon_pesquisar;
    }
}
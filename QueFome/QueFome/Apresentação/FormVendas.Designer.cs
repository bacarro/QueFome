namespace QueFome
{
    partial class FormVendas
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
            txt_id = new TextBox();
            icon_pesquisar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txt_NomeDoCriente = new TextBox();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            txt_grupo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmb_quantidade = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_total = new Label();
            lv_carrinho = new ListView();
            col_id = new ColumnHeader();
            col_grupo = new ColumnHeader();
            col_nome = new ColumnHeader();
            col_valor = new ColumnHeader();
            col_quantidade = new ColumnHeader();
            col_total = new ColumnHeader();
            btn_confirmar = new Button();
            btn_excluir = new Button();
            btn_adicionar = new Button();
            btn_remover = new Button();
            lv_produto = new ListView();
            col1_id = new ColumnHeader();
            col1_grupo = new ColumnHeader();
            col1_nome = new ColumnHeader();
            col_preco = new ColumnHeader();
            txt_pesquisar = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.Location = new Point(37, 166);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(46, 34);
            txt_id.TabIndex = 0;
            // 
            // icon_pesquisar
            // 
            icon_pesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            icon_pesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icon_pesquisar.IconColor = Color.Red;
            icon_pesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_pesquisar.IconSize = 36;
            icon_pesquisar.Location = new Point(279, 90);
            icon_pesquisar.Name = "icon_pesquisar";
            icon_pesquisar.Size = new Size(43, 38);
            icon_pesquisar.TabIndex = 1;
            icon_pesquisar.UseVisualStyleBackColor = true;
            icon_pesquisar.Click += icon_pesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto *";
            // 
            // txt_NomeDoCriente
            // 
            txt_NomeDoCriente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NomeDoCriente.Location = new Point(543, 90);
            txt_NomeDoCriente.Name = "txt_NomeDoCriente";
            txt_NomeDoCriente.Size = new Size(253, 38);
            txt_NomeDoCriente.TabIndex = 3;
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nome.Location = new Point(103, 166);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(222, 34);
            txt_nome.TabIndex = 4;
            // 
            // txt_preco
            // 
            txt_preco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_preco.Location = new Point(561, 168);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(93, 34);
            txt_preco.TabIndex = 5;
            // 
            // txt_grupo
            // 
            txt_grupo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_grupo.Location = new Point(341, 166);
            txt_grupo.Name = "txt_grupo";
            txt_grupo.Size = new Size(106, 34);
            txt_grupo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(543, 62);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 9;
            label2.Text = "Nome do Cliente *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 138);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 10;
            label3.Text = "Nome do Produto";
            // 
            // cmb_quantidade
            // 
            cmb_quantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_quantidade.FormattingEnabled = true;
            cmb_quantidade.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmb_quantidade.Location = new Point(474, 166);
            cmb_quantidade.Name = "cmb_quantidade";
            cmb_quantidade.Size = new Size(60, 36);
            cmb_quantidade.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(341, 138);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 12;
            label4.Text = "Grupo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(445, 138);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 13;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(577, 138);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 14;
            label6.Text = "Valor";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_total.Location = new Point(725, 470);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(46, 25);
            lbl_total.TabIndex = 15;
            lbl_total.Text = "0,00";
            // 
            // lv_carrinho
            // 
            lv_carrinho.Columns.AddRange(new ColumnHeader[] { col_id, col_grupo, col_nome, col_valor, col_quantidade, col_total });
            lv_carrinho.FullRowSelect = true;
            lv_carrinho.GridLines = true;
            lv_carrinho.Location = new Point(41, 259);
            lv_carrinho.Name = "lv_carrinho";
            lv_carrinho.Size = new Size(755, 199);
            lv_carrinho.TabIndex = 16;
            lv_carrinho.UseCompatibleStateImageBehavior = false;
            lv_carrinho.View = View.Details;
            // 
            // col_id
            // 
            col_id.Text = "ID";
            col_id.Width = 80;
            // 
            // col_grupo
            // 
            col_grupo.Text = "Grupo";
            col_grupo.Width = 150;
            // 
            // col_nome
            // 
            col_nome.Text = "Nome";
            col_nome.Width = 200;
            // 
            // col_valor
            // 
            col_valor.Text = "Valor";
            col_valor.Width = 120;
            // 
            // col_quantidade
            // 
            col_quantidade.Text = "Quantidade";
            col_quantidade.Width = 80;
            // 
            // col_total
            // 
            col_total.Text = "Total";
            col_total.Width = 120;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.Chartreuse;
            btn_confirmar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirmar.ForeColor = Color.Black;
            btn_confirmar.Location = new Point(170, 503);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(191, 50);
            btn_confirmar.TabIndex = 17;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.Red;
            btn_excluir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_excluir.ForeColor = Color.Black;
            btn_excluir.Location = new Point(478, 503);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(191, 50);
            btn_excluir.TabIndex = 18;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = Color.Chartreuse;
            btn_adicionar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicionar.ForeColor = Color.Black;
            btn_adicionar.Location = new Point(660, 138);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(136, 40);
            btn_adicionar.TabIndex = 19;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_remover
            // 
            btn_remover.BackColor = Color.Crimson;
            btn_remover.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_remover.ForeColor = Color.Black;
            btn_remover.Location = new Point(660, 193);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(136, 40);
            btn_remover.TabIndex = 20;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = false;
            btn_remover.Click += btn_remover_Click;
            // 
            // lv_produto
            // 
            lv_produto.Columns.AddRange(new ColumnHeader[] { col1_id, col1_grupo, col1_nome, col_preco });
            lv_produto.FullRowSelect = true;
            lv_produto.GridLines = true;
            lv_produto.Location = new Point(21, 12);
            lv_produto.Name = "lv_produto";
            lv_produto.Size = new Size(10, 10);
            lv_produto.TabIndex = 21;
            lv_produto.UseCompatibleStateImageBehavior = false;
            lv_produto.View = View.Details;
            lv_produto.SelectedIndexChanged += lv_produto_SelectedIndexChanged;
            // 
            // col1_id
            // 
            col1_id.Text = "ID";
            // 
            // col1_grupo
            // 
            col1_grupo.Text = "Grupo";
            // 
            // col1_nome
            // 
            col1_nome.Text = "Nome";
            // 
            // col_preco
            // 
            col_preco.Text = "Preço";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pesquisar.Location = new Point(41, 90);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.Size = new Size(241, 38);
            txt_pesquisar.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(37, 138);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 23;
            label8.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(646, 470);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 24;
            label9.Text = "TOTAL";
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(845, 658);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txt_pesquisar);
            Controls.Add(lv_produto);
            Controls.Add(btn_remover);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_confirmar);
            Controls.Add(lv_carrinho);
            Controls.Add(lbl_total);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmb_quantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_grupo);
            Controls.Add(txt_preco);
            Controls.Add(txt_nome);
            Controls.Add(txt_NomeDoCriente);
            Controls.Add(label1);
            Controls.Add(icon_pesquisar);
            Controls.Add(txt_id);
            ForeColor = Color.Gainsboro;
            Name = "FormVendas";
            Text = "Vendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private FontAwesome.Sharp.IconButton icon_pesquisar;
        private Label label1;
        private TextBox txt_NomeDoCriente;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private TextBox txt_grupo;
        private Label label2;
        private Label label3;
        private ComboBox cmb_quantidade;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_total;
        private ListView lv_carrinho;
        private Button btn_confirmar;
        private Button btn_excluir;
        private Button btn_adicionar;
        private ColumnHeader col_id;
        private ColumnHeader col_grupo;
        private ColumnHeader col_nome;
        private ColumnHeader col_valor;
        private ColumnHeader col_quantidade;
        private ColumnHeader col_total;
        private Button btn_remover;
        private ListView lv_produto;
        private ColumnHeader col1_id;
        private ColumnHeader col1_grupo;
        private ColumnHeader col1_nome;
        private ColumnHeader col_preco;
        private TextBox txt_pesquisar;
        private Label label8;
        private Label label9;
    }
}
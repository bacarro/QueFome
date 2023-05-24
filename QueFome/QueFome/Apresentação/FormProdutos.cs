using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueFome
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            PopularGrade();
        }
        private void PopularGrade()
        {
            string[] item = new string[4];
            var listaProdutos = Produtos.GetListaProdutos();

            foreach (Produtos produto in listaProdutos)
            {
                item[0] = produto.Id.ToString();
                item[1] = produto.Grupo;
                item[2] = produto.Nome;
                item[3] = produto.Preco.ToString("N2");

                lv_produto.Items.Add(new ListViewItem(item));
            }
            ListViewSort(lv_produto, 2, true);
        }
        private void Limpar()
        {
            txt_id.Clear();
            txt_grupo.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
            txt_id.Focus();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("O campo ID não pode ser vazio");
                txt_id.Focus();
                return;
            }
            if (txt_grupo.Text == "")
            {
                MessageBox.Show("O campo Grupo não pode ser vazio");
                txt_grupo.Focus();
                return;
            }
            if (txt_nome.Text == "")
            {
                MessageBox.Show("O campo Nome não pode ser vazio");
                txt_nome.Focus();
                return;
            }
            if (txt_preco.Text == "")
            {
                MessageBox.Show("O campo Preço não pode ser vazio");
                txt_preco.Focus();
                return;
            }

            string[] pr = new string[4];
            pr[0] = txt_id.Text;
            pr[1] = txt_grupo.Text;
            pr[2] = txt_nome.Text;
            pr[3] = txt_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produto.Items.Add(l);
            Limpar();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            lv_produto.Items.RemoveAt(lv_produto.SelectedIndices[0]);
        }
        private void obter()
        {
            txt_id.Text = lv_produto.SelectedItems[0].SubItems[0].Text;
            txt_grupo.Text = lv_produto.SelectedItems[0].SubItems[1].Text;
            txt_nome.Text = lv_produto.SelectedItems[0].SubItems[2].Text;
            txt_preco.Text = lv_produto.SelectedItems[0].SubItems[3].Text;
        }

        private void lv_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_produto.SelectedItems.Count > 0)
            {
                obter();
            }
        }
        public class Produtos
        {
            public int Id { get; set; }
            public string Grupo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            public Produtos(int id, string grupo, string nome, decimal preco)
            {
                this.Id = id;
                this.Grupo = grupo;
                this.Nome = nome;
                this.Preco = preco;
            }
            public static List<Produtos> GetListaProdutos()
            {
                //Instanciar um objeto Lista de produto

                var listaProdutos = new List<Produtos>();

                listaProdutos.Add(new Produtos(1, "Combo", "3 SANDUÍCHES + 3 MCFRITAS MÉDIAS", 66.00M));
                listaProdutos.Add(new Produtos(2, "Combo", "MCOFERTA MÉDIA CLÁSSICA + NUGGETS 4 OU CHEESEBURGUER OU MCFLURRY", 34.90M));
                listaProdutos.Add(new Produtos(3, "Combo", "2 MCOFERTAS MÉDIAS", 52.90M));
                listaProdutos.Add(new Produtos(4, "Combo", "SANDUÍCHE + BEBIDA", 19.90M));
                listaProdutos.Add(new Produtos(5, "SANDUÍCHE", "BRABO BACON SALAD", 33.90M));
                listaProdutos.Add(new Produtos(6, "SANDUÍCHE", "BIG TASTY", 34.90M));
                listaProdutos.Add(new Produtos(7, "SANDUÍCHE", "DUPLO QUARTERÃO", 33.90M));
                listaProdutos.Add(new Produtos(8, "SANDUÍCHE", "DUPLO CHEDDAR MCMELT", 33.90M));
                listaProdutos.Add(new Produtos(9, "SANDUÍCHE", "Mac Checken", 23.90M));
                listaProdutos.Add(new Produtos(10, "SANDUÍCHE", "DUPLO BURGER BACON", 24.90M));
                listaProdutos.Add(new Produtos(12, "REFRIGERANTE", "Coca-Cola 350ml", 5.00M));
                listaProdutos.Add(new Produtos(13, "REFRIGERANTE", "Coca-Cola 0% 350ml", 5.00M));
                listaProdutos.Add(new Produtos(14, "REFRIGERANTE", "Coca-Cola 600ml", 7.00M));
                listaProdutos.Add(new Produtos(15, "REFRIGERANTE", "Guaraná 350ml", 5.00M));
                listaProdutos.Add(new Produtos(16, "REFRIGERANTE", "Guaraná 0% 350ml", 5.00M));
                listaProdutos.Add(new Produtos(17, "REFRIGERANTE", "Guaraná 600ml", 7.00M));
                listaProdutos.Add(new Produtos(18, "REFRIGERANTE", "Suco 350ml", 6.00M));
                listaProdutos.Add(new Produtos(19, "REFRIGERANTE", "Suco 500ml", 8.50M));

                return listaProdutos;
            }
        }
        private void ListViewSort(ListView listView, int coluna, bool ascendente)
        {
            if(listView == null) return;

            ListView lstView = listView as ListView;
            int col = coluna;

            bool asc = ascendente;
            var items = lstView.Items.Cast<ListViewItem>().ToList();

            var numerico = true;
            foreach (ListViewItem item in lv_produto.Items)
            {
                if (!IsNumeric(item.SubItems[col].Text))
                {
                    numerico = false;
                    break;
                }
            }
            var sorted = new List<ListViewItem>();
            if (numerico)
                sorted = asc ? items.OrderBy(x => Convert.ToDecimal(x.SubItems[col].Text)).ToList() :
                  items.OrderByDescending(x => Convert.ToDecimal(x.SubItems[col].Text)).ToList();
            else
                //classificar como string
                sorted = asc ? items.OrderBy(x => x.SubItems[col].Text).ToList() :
                items.OrderByDescending(x => x.SubItems[col].Text).ToList();

            lstView.Items.Clear();
            lstView.Items.AddRange(sorted.ToArray());
        }
        public static bool IsNumeric(string Text)
        {
            decimal result;
            return (decimal.TryParse(Text, out result));
        }
    }
}

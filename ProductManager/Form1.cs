namespace ProductManager
{
    public partial class Frm_CadastroProduto : Form
    {
        private int proximoCodigo = 6; // Variável para armazenar o próximo código disponível

        public Frm_CadastroProduto()
        {
            InitializeComponent();

            // Vincula o evento ValueChanged para calcular a margem automaticamente nos NumericUpDown
            nud_PrecoCusto.ValueChanged += (s, e) => CalcularMargem();
            nud_PrecoVenda.ValueChanged += (s, e) => CalcularMargem();
        }

        private void Frm_CadastroProduto_Load(object sender, EventArgs e)
        {
            txt_NomeProduto.Focus();
            chk_ProdutoAtivo.Checked = true;
        }

        private void CalcularMargem()
        {
            decimal custo = nud_PrecoCusto.Value;
            decimal venda = nud_PrecoVenda.Value;

            decimal margem = venda - custo;
            txt_Margem.Text = margem.ToString("N2");

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_NomeProduto.Text))
            {
                MessageBox.Show("O campo 'Nome do Produto' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NomeProduto.Focus();
                return false;
            }
            if (cmb_Categorias.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmb_Categorias.Text))
            {
                MessageBox.Show("Selecione uma 'Categoria'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Categorias.Focus();
                return false;
            }
            if (cmb_Fornecedores.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmb_Fornecedores.Text))
            {
                MessageBox.Show("Selecione um 'Fornecedor'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Fornecedores.Focus();
                return false;
            }
            if (!decimal.TryParse(nud_PrecoCusto.Text, out decimal custo) || custo < 0)
            {
                MessageBox.Show("Informe um 'Preço de Custo' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_PrecoCusto.Focus();
                return false;
            }
            if (!decimal.TryParse(nud_PrecoVenda.Text, out decimal venda) || venda < 0)
            {
                MessageBox.Show("Informe um 'Preço de Venda' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_PrecoVenda.Focus();
                return false;
            }
            if (venda < custo)
            {
                MessageBox.Show("O 'Preço de Venda' não pode ser menor que o 'Preço de Custo'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_PrecoVenda.Focus();
                return false;
            }

            //Estoque
            if (!int.TryParse(nud_StockInicial.Text, out int estoqueInicial) || estoqueInicial < 0)
            {
                MessageBox.Show("Informe um 'Stock Inicial' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_StockInicial.Focus();
                return false;
            }
            if (!int.TryParse(nud_StockMinimo.Text, out int estoqueMinimo) || estoqueMinimo < 0)
            {
                MessageBox.Show("Informe um 'Stock Mínimo' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_StockMinimo.Focus();
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            mtb_Codigo.Clear();
            txt_NomeProduto.Clear();
            cmb_Categorias.SelectedIndex = -1;
            cmb_Categorias.Text = "Selecione...";
            cmb_Fornecedores.SelectedIndex = -1;
            cmb_Fornecedores.Text = "Selecione...";
            txt_Descricao.Clear();
            nud_PrecoCusto.Value = 0; 
            nud_PrecoVenda.Value = 0;
            txt_Margem.Text = "0,00";
            nud_StockInicial.Value = 0;
            nud_StockMinimo.Value = 0;
            chk_ProdutoAtivo.Checked = true;
            dtp_DataCadastro.Value = DateTime.Today;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            mtb_Codigo.Text = proximoCodigo.ToString("D4");

            txt_NomeProduto.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            proximoCodigo++;
            LimparCampos();
            txt_NomeProduto.Focus();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txt_NomeProduto.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtb_Codigo.Text))
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmacao == DialogResult.Yes)
            {
                MessageBox.Show("Produto excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }
    }
}

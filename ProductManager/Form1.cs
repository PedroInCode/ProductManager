namespace ProductManager
{
    public partial class Frm_CadastroProduto : Form
    {
        private int proximoCodigo = 1; // Variável para armazenar o próximo código disponível

        public Frm_CadastroProduto()
        {
            InitializeComponent();

            // Vincula o evento ValueChanged para calcular a margem automaticamente nos NumericUpDown
            nud_PrecoCusto.ValueChanged += (s, e) => CalcularMargem(); 
            nud_PrecoVenda.ValueChanged += (s, e) => CalcularMargem();
        }
        private void Frm_CadastroProduto_Load(object sender, EventArgs e)
        {
            txt_NomeProduto.Focus(); // Define o foco inicial para o campo "Nome do Produto"
            chk_ProdutoAtivo.Checked = true; // Define o checkbox como marcado por padrão
        }
        private void CalcularMargem()
        {
            decimal custo = nud_PrecoCusto.Value; // Obtém o valor do Preço de Custo
            decimal venda = nud_PrecoVenda.Value; // Obtém o valor do Preço de Venda

            decimal margem = venda - custo; // Calcula a margem de lucro
            txt_Margem.Text = margem.ToString("N2"); // Atualiza o campo de margem com o valor calculado, formatado com duas casas decimais

        }
        private bool ValidarCampos()
        {
            // Valida os campos obrigatórios e exibe mensagens de aviso se algum campo estiver inválido
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
            // Limpa todos os campos do formulário e redefine os valores para o estado inicial
            mtb_Codigo.Clear();
            mtb_Codigo.Text = "000000"; 
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
            LimparCampos(); // Limpa os campos do formulário

            mtb_Codigo.Text = proximoCodigo.ToString("D6"); // Define o próximo código disponível no campo de código, formatado com 6 dígitos

            txt_NomeProduto.Focus(); // Define o foco para o campo "Nome do Produto" após limpar os campos
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) // Valida os campos antes de salvar
            {
                return;
            }

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            proximoCodigo++; // Incrementa o próximo código disponível para o próximo produto
            LimparCampos(); // Limpa os campos do formulário após salvar
            txt_NomeProduto.Focus(); // Define o foco para o campo "Nome do Produto" após salvar
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); // Limpa os campos do formulário
            txt_NomeProduto.Focus(); // Define o foco para o campo "Nome do Produto" após limpar os campos
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Verifica se há um produto selecionado para exclusão
            if (string.IsNullOrWhiteSpace(mtb_Codigo.Text))
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exibe uma mensagem de confirmação antes de excluir o produto
            var confirmacao = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmacao == DialogResult.Yes)
            {
                MessageBox.Show("Produto excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }

            txt_NomeProduto.Focus(); // Define o foco para o campo "Nome do Produto" após a exclusão
        }
    }
}

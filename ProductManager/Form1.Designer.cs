namespace ProductManager
{
    partial class Frm_CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroProduto));
            pnl_painelTitulo = new Panel();
            lbl_Titulo = new Label();
            pictureBox1 = new PictureBox();
            grp_DadosPrincipais = new GroupBox();
            txt_Descricao = new TextBox();
            lbl_Descricao = new Label();
            cmb_Categorias = new ComboBox();
            txt_NomeProduto = new TextBox();
            lbl_Categoria = new Label();
            lbl_NomeProduto = new Label();
            cmb_Fornecedores = new ComboBox();
            lbl_Fonercedor = new Label();
            lbl_Codigo = new Label();
            mtb_Codigo = new MaskedTextBox();
            grp_PrecificacaoEstoque = new GroupBox();
            nud_PrecoVenda = new NumericUpDown();
            lbl_PrecoVenda = new Label();
            nud_StockMinimo = new NumericUpDown();
            lbl_EstoqueMinimo = new Label();
            nud_StockInicial = new NumericUpDown();
            lbl_Estoque = new Label();
            txt_Margem = new TextBox();
            lbl_Margem = new Label();
            nud_PrecoCusto = new NumericUpDown();
            lbl_PrecoProduto = new Label();
            grp_SituacaoDetalhes = new GroupBox();
            dtp_DataCadastro = new DateTimePicker();
            lbl_DataCadastro = new Label();
            chk_ProdutoAtivo = new CheckBox();
            panel1 = new Panel();
            btn_Excluir = new Button();
            img_Excluir = new ImageList(components);
            btn_Limpar = new Button();
            img_Limpar = new ImageList(components);
            btn_Salvar = new Button();
            img_Salvar = new ImageList(components);
            btn_Novo = new Button();
            img_Novo = new ImageList(components);
            pnl_painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_DadosPrincipais.SuspendLayout();
            grp_PrecificacaoEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_PrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_StockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_StockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_PrecoCusto).BeginInit();
            grp_SituacaoDetalhes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_painelTitulo
            // 
            pnl_painelTitulo.BackColor = Color.FromArgb(39, 64, 139);
            pnl_painelTitulo.Controls.Add(lbl_Titulo);
            pnl_painelTitulo.Controls.Add(pictureBox1);
            pnl_painelTitulo.Dock = DockStyle.Top;
            pnl_painelTitulo.ForeColor = Color.White;
            pnl_painelTitulo.Location = new Point(0, 0);
            pnl_painelTitulo.Name = "pnl_painelTitulo";
            pnl_painelTitulo.Size = new Size(983, 72);
            pnl_painelTitulo.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(78, 18);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(320, 36);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "Cadastro de Produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icone_titulo;
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // grp_DadosPrincipais
            // 
            grp_DadosPrincipais.Controls.Add(txt_Descricao);
            grp_DadosPrincipais.Controls.Add(lbl_Descricao);
            grp_DadosPrincipais.Controls.Add(cmb_Categorias);
            grp_DadosPrincipais.Controls.Add(txt_NomeProduto);
            grp_DadosPrincipais.Controls.Add(lbl_Categoria);
            grp_DadosPrincipais.Controls.Add(lbl_NomeProduto);
            grp_DadosPrincipais.Controls.Add(cmb_Fornecedores);
            grp_DadosPrincipais.Controls.Add(lbl_Fonercedor);
            grp_DadosPrincipais.Controls.Add(lbl_Codigo);
            grp_DadosPrincipais.Controls.Add(mtb_Codigo);
            grp_DadosPrincipais.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_DadosPrincipais.Location = new Point(12, 87);
            grp_DadosPrincipais.Name = "grp_DadosPrincipais";
            grp_DadosPrincipais.Size = new Size(957, 277);
            grp_DadosPrincipais.TabIndex = 0;
            grp_DadosPrincipais.TabStop = false;
            grp_DadosPrincipais.Text = "Dados Principais";
            // 
            // txt_Descricao
            // 
            txt_Descricao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Descricao.Location = new Point(274, 157);
            txt_Descricao.Multiline = true;
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.ScrollBars = ScrollBars.Vertical;
            txt_Descricao.Size = new Size(663, 99);
            txt_Descricao.TabIndex = 8;
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.AutoSize = true;
            lbl_Descricao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Descricao.Location = new Point(274, 127);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(101, 22);
            lbl_Descricao.TabIndex = 7;
            lbl_Descricao.Text = "Descrição:";
            // 
            // cmb_Categorias
            // 
            cmb_Categorias.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_Categorias.FormattingEnabled = true;
            cmb_Categorias.Items.AddRange(new object[] { "Embalagens", "Confeitaria", "Ingredientes para Panificação", "Laticínios", "Biscoitos e Bolachas", "Salgados", "Bebidas", "Doces e Sobremesas", "Bolos e Tortas", "Pães" });
            cmb_Categorias.Location = new Point(707, 72);
            cmb_Categorias.Name = "cmb_Categorias";
            cmb_Categorias.Size = new Size(230, 30);
            cmb_Categorias.TabIndex = 4;
            cmb_Categorias.Text = "Selecione...";
            // 
            // txt_NomeProduto
            // 
            txt_NomeProduto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NomeProduto.Location = new Point(206, 73);
            txt_NomeProduto.Name = "txt_NomeProduto";
            txt_NomeProduto.Size = new Size(478, 29);
            txt_NomeProduto.TabIndex = 2;
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Categoria.Location = new Point(707, 38);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(109, 22);
            lbl_Categoria.TabIndex = 3;
            lbl_Categoria.Text = "Categoria: *";
            // 
            // lbl_NomeProduto
            // 
            lbl_NomeProduto.AutoSize = true;
            lbl_NomeProduto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeProduto.Location = new Point(206, 38);
            lbl_NomeProduto.Name = "lbl_NomeProduto";
            lbl_NomeProduto.Size = new Size(177, 22);
            lbl_NomeProduto.TabIndex = 1;
            lbl_NomeProduto.Text = "Nome do Produto: *";
            // 
            // cmb_Fornecedores
            // 
            cmb_Fornecedores.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_Fornecedores.FormattingEnabled = true;
            cmb_Fornecedores.Items.AddRange(new object[] { "Bunge Professional", "M. Dias Branco", "Lesaffre", "Puratos", "Rich's", "Scala", "Piracanjuba", "Tirol", "Catupiry", "Galvanotek", "MultiCaixas Neto", "Central dos Pães", "Faleiro Food Service", "Assaí Atacadista", "Atacadão", "Roldão" });
            cmb_Fornecedores.Location = new Point(16, 156);
            cmb_Fornecedores.Name = "cmb_Fornecedores";
            cmb_Fornecedores.Size = new Size(230, 30);
            cmb_Fornecedores.TabIndex = 6;
            cmb_Fornecedores.Text = "Selecione...";
            // 
            // lbl_Fonercedor
            // 
            lbl_Fonercedor.AutoSize = true;
            lbl_Fonercedor.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Fonercedor.Location = new Point(12, 127);
            lbl_Fonercedor.Name = "lbl_Fonercedor";
            lbl_Fonercedor.Size = new Size(126, 22);
            lbl_Fonercedor.TabIndex = 5;
            lbl_Fonercedor.Text = "Fornecedor: *";
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Codigo.Location = new Point(12, 38);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(77, 22);
            lbl_Codigo.TabIndex = 0;
            lbl_Codigo.Text = "Código:";
            // 
            // mtb_Codigo
            // 
            mtb_Codigo.Enabled = false;
            mtb_Codigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtb_Codigo.Location = new Point(16, 73);
            mtb_Codigo.Mask = "000000";
            mtb_Codigo.Name = "mtb_Codigo";
            mtb_Codigo.Size = new Size(168, 29);
            mtb_Codigo.TabIndex = 10;
            mtb_Codigo.Text = "000000";
            // 
            // grp_PrecificacaoEstoque
            // 
            grp_PrecificacaoEstoque.Controls.Add(nud_PrecoVenda);
            grp_PrecificacaoEstoque.Controls.Add(lbl_PrecoVenda);
            grp_PrecificacaoEstoque.Controls.Add(nud_StockMinimo);
            grp_PrecificacaoEstoque.Controls.Add(lbl_EstoqueMinimo);
            grp_PrecificacaoEstoque.Controls.Add(nud_StockInicial);
            grp_PrecificacaoEstoque.Controls.Add(lbl_Estoque);
            grp_PrecificacaoEstoque.Controls.Add(txt_Margem);
            grp_PrecificacaoEstoque.Controls.Add(lbl_Margem);
            grp_PrecificacaoEstoque.Controls.Add(nud_PrecoCusto);
            grp_PrecificacaoEstoque.Controls.Add(lbl_PrecoProduto);
            grp_PrecificacaoEstoque.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_PrecificacaoEstoque.Location = new Point(12, 370);
            grp_PrecificacaoEstoque.Name = "grp_PrecificacaoEstoque";
            grp_PrecificacaoEstoque.Size = new Size(674, 220);
            grp_PrecificacaoEstoque.TabIndex = 2;
            grp_PrecificacaoEstoque.TabStop = false;
            grp_PrecificacaoEstoque.Text = "Precificação e Estoque";
            // 
            // nud_PrecoVenda
            // 
            nud_PrecoVenda.DecimalPlaces = 2;
            nud_PrecoVenda.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_PrecoVenda.Location = new Point(559, 43);
            nud_PrecoVenda.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_PrecoVenda.Name = "nud_PrecoVenda";
            nud_PrecoVenda.Size = new Size(109, 29);
            nud_PrecoVenda.TabIndex = 9;
            // 
            // lbl_PrecoVenda
            // 
            lbl_PrecoVenda.AutoSize = true;
            lbl_PrecoVenda.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PrecoVenda.Location = new Point(349, 45);
            lbl_PrecoVenda.Name = "lbl_PrecoVenda";
            lbl_PrecoVenda.Size = new Size(194, 22);
            lbl_PrecoVenda.TabIndex = 8;
            lbl_PrecoVenda.Text = "Preço de Venda (R$):";
            // 
            // nud_StockMinimo
            // 
            nud_StockMinimo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_StockMinimo.Location = new Point(476, 167);
            nud_StockMinimo.Name = "nud_StockMinimo";
            nud_StockMinimo.Size = new Size(101, 29);
            nud_StockMinimo.TabIndex = 7;
            // 
            // lbl_EstoqueMinimo
            // 
            lbl_EstoqueMinimo.AutoSize = true;
            lbl_EstoqueMinimo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EstoqueMinimo.Location = new Point(308, 169);
            lbl_EstoqueMinimo.Name = "lbl_EstoqueMinimo";
            lbl_EstoqueMinimo.Size = new Size(130, 22);
            lbl_EstoqueMinimo.TabIndex = 6;
            lbl_EstoqueMinimo.Text = "Stock Mínimo:";
            // 
            // nud_StockInicial
            // 
            nud_StockInicial.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_StockInicial.Location = new Point(175, 167);
            nud_StockInicial.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_StockInicial.Name = "nud_StockInicial";
            nud_StockInicial.Size = new Size(103, 29);
            nud_StockInicial.TabIndex = 5;
            // 
            // lbl_Estoque
            // 
            lbl_Estoque.AutoSize = true;
            lbl_Estoque.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Estoque.Location = new Point(11, 169);
            lbl_Estoque.Name = "lbl_Estoque";
            lbl_Estoque.Size = new Size(116, 22);
            lbl_Estoque.TabIndex = 4;
            lbl_Estoque.Text = "Stock Inicial:";
            // 
            // txt_Margem
            // 
            txt_Margem.Enabled = false;
            txt_Margem.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Margem.Location = new Point(175, 103);
            txt_Margem.Name = "txt_Margem";
            txt_Margem.Size = new Size(103, 29);
            txt_Margem.TabIndex = 3;
            txt_Margem.Text = "0,00";
            // 
            // lbl_Margem
            // 
            lbl_Margem.AutoSize = true;
            lbl_Margem.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Margem.Location = new Point(11, 106);
            lbl_Margem.Name = "lbl_Margem";
            lbl_Margem.Size = new Size(126, 22);
            lbl_Margem.TabIndex = 2;
            lbl_Margem.Text = "Margem (R$):";
            // 
            // nud_PrecoCusto
            // 
            nud_PrecoCusto.DecimalPlaces = 2;
            nud_PrecoCusto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_PrecoCusto.Location = new Point(223, 43);
            nud_PrecoCusto.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_PrecoCusto.Name = "nud_PrecoCusto";
            nud_PrecoCusto.Size = new Size(103, 29);
            nud_PrecoCusto.TabIndex = 1;
            nud_PrecoCusto.ThousandsSeparator = true;
            
            // 
            // lbl_PrecoProduto
            // 
            lbl_PrecoProduto.AutoSize = true;
            lbl_PrecoProduto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PrecoProduto.Location = new Point(11, 45);
            lbl_PrecoProduto.Name = "lbl_PrecoProduto";
            lbl_PrecoProduto.Size = new Size(190, 22);
            lbl_PrecoProduto.TabIndex = 0;
            lbl_PrecoProduto.Text = "Preço de Custo (R$):";
            // 
            // grp_SituacaoDetalhes
            // 
            grp_SituacaoDetalhes.Controls.Add(dtp_DataCadastro);
            grp_SituacaoDetalhes.Controls.Add(lbl_DataCadastro);
            grp_SituacaoDetalhes.Controls.Add(chk_ProdutoAtivo);
            grp_SituacaoDetalhes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_SituacaoDetalhes.Location = new Point(692, 370);
            grp_SituacaoDetalhes.Name = "grp_SituacaoDetalhes";
            grp_SituacaoDetalhes.Size = new Size(277, 220);
            grp_SituacaoDetalhes.TabIndex = 3;
            grp_SituacaoDetalhes.TabStop = false;
            grp_SituacaoDetalhes.Text = "Situação / Detalhes";
            // 
            // dtp_DataCadastro
            // 
            dtp_DataCadastro.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_DataCadastro.Format = DateTimePickerFormat.Short;
            dtp_DataCadastro.Location = new Point(27, 137);
            dtp_DataCadastro.Name = "dtp_DataCadastro";
            dtp_DataCadastro.Size = new Size(200, 29);
            dtp_DataCadastro.TabIndex = 2;
            // 
            // lbl_DataCadastro
            // 
            lbl_DataCadastro.AutoSize = true;
            lbl_DataCadastro.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DataCadastro.Location = new Point(22, 103);
            lbl_DataCadastro.Name = "lbl_DataCadastro";
            lbl_DataCadastro.Size = new Size(163, 22);
            lbl_DataCadastro.TabIndex = 1;
            lbl_DataCadastro.Text = "Data de Cadastro:";
            // 
            // chk_ProdutoAtivo
            // 
            chk_ProdutoAtivo.AutoSize = true;
            chk_ProdutoAtivo.Checked = true;
            chk_ProdutoAtivo.CheckState = CheckState.Checked;
            chk_ProdutoAtivo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_ProdutoAtivo.Location = new Point(27, 45);
            chk_ProdutoAtivo.Name = "chk_ProdutoAtivo";
            chk_ProdutoAtivo.Size = new Size(142, 26);
            chk_ProdutoAtivo.TabIndex = 0;
            chk_ProdutoAtivo.Text = "Produto Ativo";
            chk_ProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Excluir);
            panel1.Controls.Add(btn_Limpar);
            panel1.Controls.Add(btn_Salvar);
            panel1.Controls.Add(btn_Novo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 602);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 73);
            panel1.TabIndex = 4;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Excluir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Excluir.ImageIndex = 0;
            btn_Excluir.ImageList = img_Excluir;
            btn_Excluir.Location = new Point(621, 17);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(103, 44);
            btn_Excluir.TabIndex = 3;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.TextAlign = ContentAlignment.MiddleRight;
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // img_Excluir
            // 
            img_Excluir.ColorDepth = ColorDepth.Depth32Bit;
            img_Excluir.ImageStream = (ImageListStreamer)resources.GetObject("img_Excluir.ImageStream");
            img_Excluir.TransparentColor = Color.Transparent;
            img_Excluir.Images.SetKeyName(0, "simbolo-excluir.png");
            // 
            // btn_Limpar
            // 
            btn_Limpar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Limpar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Limpar.ImageIndex = 0;
            btn_Limpar.ImageList = img_Limpar;
            btn_Limpar.Location = new Point(498, 17);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(102, 44);
            btn_Limpar.TabIndex = 2;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.TextAlign = ContentAlignment.MiddleRight;
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // img_Limpar
            // 
            img_Limpar.ColorDepth = ColorDepth.Depth32Bit;
            img_Limpar.ImageStream = (ImageListStreamer)resources.GetObject("img_Limpar.ImageStream");
            img_Limpar.TransparentColor = Color.Transparent;
            img_Limpar.Images.SetKeyName(0, "simbolo-limpar.png");
            // 
            // btn_Salvar
            // 
            btn_Salvar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Salvar.ImageIndex = 0;
            btn_Salvar.ImageList = img_Salvar;
            btn_Salvar.Location = new Point(380, 17);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(97, 44);
            btn_Salvar.TabIndex = 1;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // img_Salvar
            // 
            img_Salvar.ColorDepth = ColorDepth.Depth32Bit;
            img_Salvar.ImageStream = (ImageListStreamer)resources.GetObject("img_Salvar.ImageStream");
            img_Salvar.TransparentColor = Color.Transparent;
            img_Salvar.Images.SetKeyName(0, "simbolo-salvar.png");
            // 
            // btn_Novo
            // 
            btn_Novo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Novo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Novo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Novo.ImageIndex = 0;
            btn_Novo.ImageList = img_Novo;
            btn_Novo.Location = new Point(268, 17);
            btn_Novo.Name = "btn_Novo";
            btn_Novo.Size = new Size(91, 44);
            btn_Novo.TabIndex = 0;
            btn_Novo.Text = "Novo";
            btn_Novo.TextAlign = ContentAlignment.MiddleRight;
            btn_Novo.UseVisualStyleBackColor = true;
            btn_Novo.Click += btn_Novo_Click;
            // 
            // img_Novo
            // 
            img_Novo.ColorDepth = ColorDepth.Depth32Bit;
            img_Novo.ImageStream = (ImageListStreamer)resources.GetObject("img_Novo.ImageStream");
            img_Novo.TransparentColor = Color.Transparent;
            img_Novo.Images.SetKeyName(0, "simbolo-novo-arquivo.png");
            // 
            // Frm_CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 675);
            Controls.Add(panel1);
            Controls.Add(grp_SituacaoDetalhes);
            Controls.Add(grp_PrecificacaoEstoque);
            Controls.Add(grp_DadosPrincipais);
            Controls.Add(pnl_painelTitulo);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            pnl_painelTitulo.ResumeLayout(false);
            pnl_painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_DadosPrincipais.ResumeLayout(false);
            grp_DadosPrincipais.PerformLayout();
            grp_PrecificacaoEstoque.ResumeLayout(false);
            grp_PrecificacaoEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_PrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_StockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_StockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_PrecoCusto).EndInit();
            grp_SituacaoDetalhes.ResumeLayout(false);
            grp_SituacaoDetalhes.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_painelTitulo;
        private Label lbl_Titulo;
        private GroupBox grp_DadosPrincipais;
        private GroupBox grp_PrecificacaoEstoque;
        private GroupBox grp_SituacaoDetalhes;
        private Label lbl_Fonercedor;
        private Label lbl_Codigo;
        private MaskedTextBox mtb_Codigo;
        private Panel panel1;
        private ComboBox cmb_Fornecedores;
        private TextBox txt_NomeProduto;
        private Label lbl_Categoria;
        private Label lbl_NomeProduto;
        private ComboBox cmb_Categorias;
        private TextBox txt_Descricao;
        private Label lbl_Descricao;
        private Label lbl_PrecoProduto;
        private Label lbl_Margem;
        private NumericUpDown nud_PrecoCusto;
        private Label lbl_EstoqueMinimo;
        private NumericUpDown nud_StockInicial;
        private Label lbl_Estoque;
        private TextBox txt_Margem;
        private Label lbl_PrecoVenda;
        private NumericUpDown nud_StockMinimo;
        private NumericUpDown nud_PrecoVenda;
        private Label lbl_DataCadastro;
        private CheckBox chk_ProdutoAtivo;
        private DateTimePicker dtp_DataCadastro;
        private PictureBox pictureBox1;
        private Button btn_Excluir;
        private Button btn_Limpar;
        private Button btn_Salvar;
        private Button btn_Novo;
        private ImageList img_Novo;
        private ImageList img_Salvar;
        private ImageList img_Excluir;
        private ImageList img_Limpar;
    }
}

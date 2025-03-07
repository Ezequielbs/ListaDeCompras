namespace ListaDeCompras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.gpCadastro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbUnMedida = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.gpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(44, 28);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(689, 150);
            this.dgvTabela.TabIndex = 0;
            // 
            // gpCadastro
            // 
            this.gpCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gpCadastro.Controls.Add(this.label4);
            this.gpCadastro.Controls.Add(this.label3);
            this.gpCadastro.Controls.Add(this.label2);
            this.gpCadastro.Controls.Add(this.label1);
            this.gpCadastro.Controls.Add(this.label);
            this.gpCadastro.Controls.Add(this.cbUnMedida);
            this.gpCadastro.Controls.Add(this.cbCategoria);
            this.gpCadastro.Controls.Add(this.txtDescricao);
            this.gpCadastro.Controls.Add(this.txtMarca);
            this.gpCadastro.Controls.Add(this.txtNomeProduto);
            this.gpCadastro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCadastro.Location = new System.Drawing.Point(44, 222);
            this.gpCadastro.Name = "gpCadastro";
            this.gpCadastro.Size = new System.Drawing.Size(689, 216);
            this.gpCadastro.TabIndex = 1;
            this.gpCadastro.TabStop = false;
            this.gpCadastro.Text = "Cadastro de Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidade de Medida";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(22, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 16);
            this.label.TabIndex = 5;
            this.label.Text = "Categoria";
            // 
            // cbUnMedida
            // 
            this.cbUnMedida.AutoCompleteCustomSource.AddRange(new string[] {
            "Peso: kg, g, mg",
            "",
            "Volume: L, mL",
            "",
            "Comprimento: m, cm, mm",
            "",
            "Unidade: un, caixa, pacote, lata, cartela"});
            this.cbUnMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUnMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnMedida.FormattingEnabled = true;
            this.cbUnMedida.Items.AddRange(new object[] {
            "Peso: kg, g, mg",
            "",
            "Volume: L, mL",
            "",
            "Comprimento: m, cm, mm",
            "",
            "Unidade: un, caixa, pacote, lata, cartela"});
            this.cbUnMedida.Location = new System.Drawing.Point(418, 45);
            this.cbUnMedida.Name = "cbUnMedida";
            this.cbUnMedida.Size = new System.Drawing.Size(165, 21);
            this.cbUnMedida.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Alimentos e Bebidas",
            "",
            "Produtos de Limpeza",
            "",
            "Higiene Pessoal",
            "",
            "Produtos de Beleza e Cuidados Pessoais",
            "",
            "",
            "Roupas e Acessórios",
            "",
            "Produtos de Eletrônicos",
            "",
            "Pet Shop",
            "",
            "Produtos de Jardim ",
            "Ferramentas",
            "",
            "Material Escolar e Escritório"});
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Alimentos e Bebidas",
            "",
            "Produtos de Limpeza",
            "",
            "Higiene Pessoal",
            "",
            "Produtos de Beleza e Cuidados Pessoais",
            "",
            "",
            "Roupas e Acessórios",
            "",
            "Produtos de Eletrônicos",
            "",
            "Pet Shop",
            "",
            "Produtos de Jardim ",
            "Ferramentas",
            "",
            "Material Escolar e Escritório"});
            this.cbCategoria.Location = new System.Drawing.Point(25, 45);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 21);
            this.cbCategoria.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(25, 145);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(303, 55);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(418, 93);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(223, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(25, 93);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(303, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(142, 5);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(44, 16);
            this.lbData.TabIndex = 10;
            this.lbData.Text = "Data:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(44, 194);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(142, 20);
            this.txtIdProduto.TabIndex = 11;
            this.txtIdProduto.TextChanged += new System.EventHandler(this.txtIdProduto_TextChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btBuscar.Location = new System.Drawing.Point(192, 191);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(58, 23);
            this.btBuscar.TabIndex = 12;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(446, 194);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(58, 31);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.Location = new System.Drawing.Point(739, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(58, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Red;
            this.btExcluir.Location = new System.Drawing.Point(537, 194);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(58, 31);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.btEditar.Location = new System.Drawing.Point(627, 194);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(58, 31);
            this.btEditar.TabIndex = 16;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Informe o ID para realizar busca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Data do Cadastro:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.gpCadastro);
            this.Controls.Add(this.dgvTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.gpCadastro.ResumeLayout(false);
            this.gpCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.GroupBox gpCadastro;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbUnMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


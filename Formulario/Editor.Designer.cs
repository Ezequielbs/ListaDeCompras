namespace ListaDeCompras.Formulario
{
    partial class Editor
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbUnMedida = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.gpCadastro = new System.Windows.Forms.GroupBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.gpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.Location = new System.Drawing.Point(418, 202);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 46);
            this.btCancelar.TabIndex = 23;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 177);
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
            this.label2.Location = new System.Drawing.Point(22, 125);
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
            this.label.Location = new System.Drawing.Point(22, 73);
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
            this.cbCategoria.Location = new System.Drawing.Point(25, 92);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 21);
            this.cbCategoria.TabIndex = 3;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(538, 202);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(112, 46);
            this.btAtualizar.TabIndex = 22;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(25, 193);
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
            this.txtNomeProduto.Location = new System.Drawing.Point(25, 141);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(303, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(8, 14);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(44, 16);
            this.lbData.TabIndex = 19;
            this.lbData.Text = "Data:";
            // 
            // gpCadastro
            // 
            this.gpCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gpCadastro.Controls.Add(this.btCancelar);
            this.gpCadastro.Controls.Add(this.label4);
            this.gpCadastro.Controls.Add(this.btAtualizar);
            this.gpCadastro.Controls.Add(this.label3);
            this.gpCadastro.Controls.Add(this.btBuscar);
            this.gpCadastro.Controls.Add(this.txtIdProduto);
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
            this.gpCadastro.Location = new System.Drawing.Point(40, 189);
            this.gpCadastro.Name = "gpCadastro";
            this.gpCadastro.Size = new System.Drawing.Size(689, 254);
            this.gpCadastro.TabIndex = 18;
            this.gpCadastro.TabStop = false;
            this.gpCadastro.Text = "Editar Produto";
            this.gpCadastro.Enter += new System.EventHandler(this.gpCadastro_Enter);
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(40, 33);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(689, 150);
            this.dgvTabela.TabIndex = 17;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btBuscar.Location = new System.Drawing.Point(173, 24);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(58, 23);
            this.btBuscar.TabIndex = 21;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(25, 26);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(142, 20);
            this.txtIdProduto.TabIndex = 20;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.gpCadastro);
            this.Controls.Add(this.dgvTabela);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.gpCadastro.ResumeLayout(false);
            this.gpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbUnMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lbData;
        public System.Windows.Forms.GroupBox gpCadastro;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtIdProduto;
    }
}
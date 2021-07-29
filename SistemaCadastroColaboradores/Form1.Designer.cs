
namespace SistemaCadastroColaboradores
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(60, 50);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.labelTelefone.Location = new System.Drawing.Point(60, 87);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(56, 17);
            this.labelTelefone.TabIndex = 1;
            this.labelTelefone.Text = "Telefone";
            this.labelTelefone.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.labelTipo.Location = new System.Drawing.Point(60, 125);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(33, 17);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 20);
            this.txtNome.TabIndex = 3;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(123, 124);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(288, 21);
            this.comboTipo.TabIndex = 4;
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(123, 87);
            this.maskedTelefone.Mask = "(00)00000-0000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(288, 20);
            this.maskedTelefone.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.buttonCadastrar.Location = new System.Drawing.Point(123, 160);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(288, 39);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 17;
            this.Lista.Location = new System.Drawing.Point(68, 235);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(565, 157);
            this.Lista.TabIndex = 7;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.buttonAlterar.Location = new System.Drawing.Point(63, 398);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(150, 30);
            this.buttonAlterar.TabIndex = 8;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.buttonExcluir.Location = new System.Drawing.Point(219, 398);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(150, 30);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.maskedTelefone);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Cadastro Colaborador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
    }
}


namespace Cadastro_de_Produtos
{
    partial class FormCadastro
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
            lblNome = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(25, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.Location = new Point(24, 63);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(68, 23);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(98, 59);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(50, 113);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(143, 45);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 180);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblPreco;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
    }
}
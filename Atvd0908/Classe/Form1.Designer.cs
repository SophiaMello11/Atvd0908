namespace Atvd0908
{
    partial class Form1
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
            label1 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtNascimento = new TextBox();
            txtRenda = new TextBox();
            btnCadastrar = new Button();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(207, 80);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 51);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ActiveCaptionText;
            txtNome.Location = new Point(189, 220);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 18;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.ForeColor = SystemColors.ActiveCaptionText;
            txtCpf.Location = new Point(189, 259);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(217, 33);
            txtCpf.TabIndex = 23;
            // 
            // txtNascimento
            // 
            txtNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNascimento.ForeColor = SystemColors.ActiveCaptionText;
            txtNascimento.Location = new Point(189, 298);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.PlaceholderText = "Data de nascimento";
            txtNascimento.Size = new Size(217, 33);
            txtNascimento.TabIndex = 24;
            txtNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // txtRenda
            // 
            txtRenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRenda.ForeColor = SystemColors.ActiveCaptionText;
            txtRenda.Location = new Point(189, 337);
            txtRenda.Name = "txtRenda";
            txtRenda.PlaceholderText = "Renda Mensal R$";
            txtRenda.Size = new Size(217, 33);
            txtRenda.TabIndex = 25;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.BlueViolet;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(221, 400);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 36);
            btnCadastrar.TabIndex = 31;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button2_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = SystemColors.ActiveCaptionText;
            txtId.Location = new Point(189, 181);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID";
            txtId.Size = new Size(217, 33);
            txtId.TabIndex = 32;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(622, 561);
            Controls.Add(txtId);
            Controls.Add(btnCadastrar);
            Controls.Add(txtRenda);
            Controls.Add(txtNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtNascimento;
        private TextBox txtRenda;
        private Button btnCadastrar;
        private TextBox txtId;
    }
}
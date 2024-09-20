namespace UsuariosGhu
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
            lblTeste = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            label5 = new Label();
            label6 = new Label();
            lblID = new Label();
            btnAtulizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // lblTeste
            // 
            lblTeste.AutoSize = true;
            lblTeste.Font = new Font("Poppins Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeste.Location = new Point(208, 9);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(163, 37);
            lblTeste.TabIndex = 0;
            lblTeste.Text = "Funcionários";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label1.Location = new Point(26, 135);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 173);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 7;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 212);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 8;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label4.Location = new Point(24, 251);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 9;
            label4.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F);
            txtNome.Location = new Point(128, 138);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(352, 22);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Arial", 9.75F);
            txtTelefone.Location = new Point(128, 178);
            txtTelefone.MaxLength = 15;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(352, 22);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F);
            txtEmail.Location = new Point(128, 212);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(352, 22);
            txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 9.75F);
            txtEndereco.Location = new Point(128, 251);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(352, 22);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Firebrick;
            btnCadastrar.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ControlLight;
            btnCadastrar.Location = new Point(26, 305);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(109, 35);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(0, 0, 192);
            btnPesquisar.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.MenuBar;
            btnPesquisar.Location = new Point(141, 305);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 35);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 86);
            label5.Name = "label5";
            label5.Size = new Size(121, 26);
            label5.TabIndex = 11;
            label5.Text = "Funcionário ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 91);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(153, 91);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 13;
            // 
            // btnAtulizar
            // 
            btnAtulizar.BackColor = Color.FromArgb(0, 192, 0);
            btnAtulizar.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtulizar.ForeColor = SystemColors.MenuBar;
            btnAtulizar.Location = new Point(256, 305);
            btnAtulizar.Name = "btnAtulizar";
            btnAtulizar.Size = new Size(109, 35);
            btnAtulizar.TabIndex = 14;
            btnAtulizar.Text = "Atualizar";
            btnAtulizar.UseVisualStyleBackColor = false;
            btnAtulizar.Click += btnAtulizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(192, 0, 192);
            btnDeletar.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.ForeColor = SystemColors.MenuBar;
            btnDeletar.Location = new Point(371, 305);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(109, 35);
            btnDeletar.TabIndex = 15;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 397);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtulizar);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTeste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTeste;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label label5;
        private Label label6;
        private Label lblID;
        private Button btnAtulizar;
        private Button btnDeletar;
    }
}

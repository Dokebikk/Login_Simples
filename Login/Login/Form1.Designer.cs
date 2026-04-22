namespace Login
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
            panel1 = new Panel();
            btnSenha = new Button();
            btnLogar = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btnRegistrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 27, 32);
            panel1.Controls.Add(btnSenha);
            panel1.Controls.Add(btnLogar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(191, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 271);
            panel1.TabIndex = 1;
            // 
            // btnSenha
            // 
            btnSenha.BackColor = Color.Transparent;
            btnSenha.FlatAppearance.BorderSize = 0;
            btnSenha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSenha.FlatStyle = FlatStyle.Flat;
            btnSenha.ForeColor = Color.FromArgb(214, 226, 230);
            btnSenha.Location = new Point(226, 163);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(115, 23);
            btnSenha.TabIndex = 5;
            btnSenha.Text = "Esqueceu a Senha?";
            btnSenha.UseVisualStyleBackColor = true;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(73, 125, 135);
            btnLogar.FlatStyle = FlatStyle.Popup;
            btnLogar.ForeColor = Color.FromArgb(214, 226, 230);
            btnLogar.Location = new Point(64, 202);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(277, 47);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "L O G I N";
            btnLogar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 230, 233);
            panel3.Location = new Point(64, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 25);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 230, 233);
            panel2.Location = new Point(64, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(47, 25);
            panel2.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 204, 204);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(174, 174, 175);
            txtSenha.Location = new Point(110, 121);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(231, 25);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 204, 204);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(174, 174, 175);
            txtEmail.Location = new Point(110, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 25);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(14, 33, 37);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = Color.FromArgb(185, 198, 202);
            btnRegistrar.Location = new Point(255, 377);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(277, 61);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "C R I A R   C O N T A";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Panel panel3;
        private Panel panel2;
        private Button btnLogar;
        private Button btnSenha;
        private Button btnRegistrar;

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}

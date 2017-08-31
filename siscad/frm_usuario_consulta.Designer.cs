namespace siscad
{
    partial class frm_usuario_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario_consulta));
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.img_login = new System.Windows.Forms.PictureBox();
            this.txt_funcionario = new System.Windows.Forms.TextBox();
            this.lb_funcionario = new System.Windows.Forms.ListBox();
            this.txt_nva = new System.Windows.Forms.TextBox();
            this.lbl_nva = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.Location = new System.Drawing.Point(165, 19);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(226, 26);
            this.lbl_funcionario.TabIndex = 34;
            this.lbl_funcionario.Text = "Nome do Funcionário:";
            // 
            // img_login
            // 
            this.img_login.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_login.ErrorImage")));
            this.img_login.Image = ((System.Drawing.Image)(resources.GetObject("img_login.Image")));
            this.img_login.InitialImage = null;
            this.img_login.Location = new System.Drawing.Point(12, 12);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(153, 146);
            this.img_login.TabIndex = 32;
            this.img_login.TabStop = false;
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.BackColor = System.Drawing.Color.White;
            this.txt_funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcionario.Location = new System.Drawing.Point(170, 48);
            this.txt_funcionario.MaxLength = 50;
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(320, 26);
            this.txt_funcionario.TabIndex = 36;
            this.txt_funcionario.TextChanged += new System.EventHandler(this.txt_funcionario_TextChanged);
            // 
            // lb_funcionario
            // 
            this.lb_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_funcionario.FormattingEnabled = true;
            this.lb_funcionario.ItemHeight = 20;
            this.lb_funcionario.Location = new System.Drawing.Point(170, 74);
            this.lb_funcionario.Name = "lb_funcionario";
            this.lb_funcionario.Size = new System.Drawing.Size(320, 84);
            this.lb_funcionario.TabIndex = 37;
            this.lb_funcionario.SelectedIndexChanged += new System.EventHandler(this.lb_funcionario_SelectedIndexChanged);
            // 
            // txt_nva
            // 
            this.txt_nva.BackColor = System.Drawing.Color.White;
            this.txt_nva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nva.Location = new System.Drawing.Point(170, 225);
            this.txt_nva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nva.Name = "txt_nva";
            this.txt_nva.ReadOnly = true;
            this.txt_nva.Size = new System.Drawing.Size(320, 26);
            this.txt_nva.TabIndex = 42;
            // 
            // lbl_nva
            // 
            this.lbl_nva.AutoSize = true;
            this.lbl_nva.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nva.Location = new System.Drawing.Point(165, 197);
            this.lbl_nva.Name = "lbl_nva";
            this.lbl_nva.Size = new System.Drawing.Size(175, 26);
            this.lbl_nva.TabIndex = 43;
            this.lbl_nva.Text = "Nível de Acesso:";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(171, 167);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.ReadOnly = true;
            this.txt_senha.Size = new System.Drawing.Size(320, 26);
            this.txt_senha.TabIndex = 41;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(170, 107);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(320, 26);
            this.txt_usuario.TabIndex = 40;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(171, 137);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(81, 26);
            this.lbl_senha.TabIndex = 39;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(166, 77);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(93, 26);
            this.lbl_usuario.TabIndex = 38;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(15, 167);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 42);
            this.btn_limpar.TabIndex = 44;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(15, 216);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(144, 42);
            this.btn_alterar.TabIndex = 45;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // frm_usuario_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 268);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lb_funcionario);
            this.Controls.Add(this.txt_nva);
            this.Controls.Add(this.lbl_nva);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_funcionario);
            this.Controls.Add(this.lbl_funcionario);
            this.Controls.Add(this.img_login);
            this.Name = "frm_usuario_consulta";
            this.Text = "CONSULTA DE USUARIO";
            this.Load += new System.EventHandler(this.frm_usuario_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.TextBox txt_funcionario;
        private System.Windows.Forms.ListBox lb_funcionario;
        private System.Windows.Forms.TextBox txt_nva;
        private System.Windows.Forms.Label lbl_nva;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_alterar;
    }
}
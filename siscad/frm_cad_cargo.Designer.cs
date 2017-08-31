namespace siscad
{
    partial class frm_cad_cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_cargo));
            this.img_login = new System.Windows.Forms.PictureBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            this.SuspendLayout();
            // 
            // img_login
            // 
            this.img_login.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_login.ErrorImage")));
            this.img_login.Image = ((System.Drawing.Image)(resources.GetObject("img_login.Image")));
            this.img_login.InitialImage = null;
            this.img_login.Location = new System.Drawing.Point(-9, 12);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(256, 216);
            this.img_login.TabIndex = 35;
            this.img_login.TabStop = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(271, 159);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 42);
            this.btn_limpar.TabIndex = 34;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(271, 101);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(144, 42);
            this.btn_cadastrar.TabIndex = 30;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_cargo
            // 
            this.txt_cargo.BackColor = System.Drawing.Color.White;
            this.txt_cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.Location = new System.Drawing.Point(253, 60);
            this.txt_cargo.MaxLength = 50;
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(187, 26);
            this.txt_cargo.TabIndex = 24;
            this.txt_cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cargo_KeyPress);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(253, 21);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(77, 26);
            this.lbl_nome.TabIndex = 23;
            this.lbl_nome.Text = "Cargo:";
            // 
            // frm_cad_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 222);
            this.Controls.Add(this.img_login);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_cad_cargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CARGO";
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.Label lbl_nome;
    }
}
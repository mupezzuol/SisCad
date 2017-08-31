namespace siscad
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.mnu_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cargo_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cargo_consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_func_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cli_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_usu_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_opcao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_opcao_usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_opcao_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_log = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_login = new System.Windows.Forms.PictureBox();
            this.mnu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_principal
            // 
            this.mnu_principal.BackColor = System.Drawing.Color.White;
            this.mnu_principal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cadastro,
            this.mnu_opcao});
            this.mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_principal.Name = "mnu_principal";
            this.mnu_principal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnu_principal.Size = new System.Drawing.Size(707, 27);
            this.mnu_principal.TabIndex = 0;
            this.mnu_principal.Text = "CADASTROS";
            this.mnu_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_principal_ItemClicked);
            // 
            // mnu_cadastro
            // 
            this.mnu_cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cargo,
            this.mnu_funcionario,
            this.mnu_cliente,
            this.mnu_usuario});
            this.mnu_cadastro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnu_cadastro.Name = "mnu_cadastro";
            this.mnu_cadastro.Size = new System.Drawing.Size(76, 23);
            this.mnu_cadastro.Text = "Cadastro";
            // 
            // mnu_cargo
            // 
            this.mnu_cargo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cargo_cadastrar,
            this.mnu_cargo_consultar});
            this.mnu_cargo.Name = "mnu_cargo";
            this.mnu_cargo.Size = new System.Drawing.Size(149, 24);
            this.mnu_cargo.Text = "Cargo";
            // 
            // mnu_cargo_cadastrar
            // 
            this.mnu_cargo_cadastrar.Name = "mnu_cargo_cadastrar";
            this.mnu_cargo_cadastrar.Size = new System.Drawing.Size(137, 24);
            this.mnu_cargo_cadastrar.Text = "Cadastrar";
            this.mnu_cargo_cadastrar.Click += new System.EventHandler(this.mnu_cargo_cadastrar_Click);
            // 
            // mnu_cargo_consultar
            // 
            this.mnu_cargo_consultar.Name = "mnu_cargo_consultar";
            this.mnu_cargo_consultar.Size = new System.Drawing.Size(137, 24);
            this.mnu_cargo_consultar.Text = "Consultar";
            // 
            // mnu_funcionario
            // 
            this.mnu_funcionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_func_cadastrar});
            this.mnu_funcionario.Name = "mnu_funcionario";
            this.mnu_funcionario.Size = new System.Drawing.Size(149, 24);
            this.mnu_funcionario.Text = "Funcionario";
            // 
            // mnu_func_cadastrar
            // 
            this.mnu_func_cadastrar.Name = "mnu_func_cadastrar";
            this.mnu_func_cadastrar.Size = new System.Drawing.Size(137, 24);
            this.mnu_func_cadastrar.Text = "Cadastrar";
            this.mnu_func_cadastrar.Click += new System.EventHandler(this.mnu_func_cadastrar_Click);
            // 
            // mnu_cliente
            // 
            this.mnu_cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cli_cadastrar});
            this.mnu_cliente.Name = "mnu_cliente";
            this.mnu_cliente.Size = new System.Drawing.Size(149, 24);
            this.mnu_cliente.Text = "Cliente";
            // 
            // mnu_cli_cadastrar
            // 
            this.mnu_cli_cadastrar.Name = "mnu_cli_cadastrar";
            this.mnu_cli_cadastrar.Size = new System.Drawing.Size(137, 24);
            this.mnu_cli_cadastrar.Text = "Cadastrar";
            this.mnu_cli_cadastrar.Click += new System.EventHandler(this.mnu_cli_cadastrar_Click);
            // 
            // mnu_usuario
            // 
            this.mnu_usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_usu_cadastrar});
            this.mnu_usuario.Name = "mnu_usuario";
            this.mnu_usuario.Size = new System.Drawing.Size(149, 24);
            this.mnu_usuario.Text = "Usuário";
            // 
            // mnu_usu_cadastrar
            // 
            this.mnu_usu_cadastrar.Name = "mnu_usu_cadastrar";
            this.mnu_usu_cadastrar.Size = new System.Drawing.Size(137, 24);
            this.mnu_usu_cadastrar.Text = "Cadastrar";
            this.mnu_usu_cadastrar.Click += new System.EventHandler(this.mnu_usu_cadastrar_Click);
            // 
            // mnu_opcao
            // 
            this.mnu_opcao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_opcao_usuario,
            this.mnu_opcao_sair});
            this.mnu_opcao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_opcao.Name = "mnu_opcao";
            this.mnu_opcao.Size = new System.Drawing.Size(59, 23);
            this.mnu_opcao.Text = "Opções";
            this.mnu_opcao.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // mnu_opcao_usuario
            // 
            this.mnu_opcao_usuario.Name = "mnu_opcao_usuario";
            this.mnu_opcao_usuario.Size = new System.Drawing.Size(150, 22);
            this.mnu_opcao_usuario.Text = "Trocar Usuário";
            this.mnu_opcao_usuario.Click += new System.EventHandler(this.mnu_opcao_usuario_Click);
            // 
            // mnu_opcao_sair
            // 
            this.mnu_opcao_sair.Name = "mnu_opcao_sair";
            this.mnu_opcao_sair.Size = new System.Drawing.Size(150, 22);
            this.mnu_opcao_sair.Text = "Sair";
            this.mnu_opcao_sair.Click += new System.EventHandler(this.mnu_opcao_sair_Click);
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log.Location = new System.Drawing.Point(66, 340);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(82, 17);
            this.lbl_log.TabIndex = 30;
            this.lbl_log.Text = "log_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-12, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(769, 7);
            this.label4.TabIndex = 29;
            this.label4.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-36, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 7);
            this.label3.TabIndex = 28;
            this.label3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Usuário:";
            // 
            // img_login
            // 
            this.img_login.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_login.ErrorImage")));
            this.img_login.Image = ((System.Drawing.Image)(resources.GetObject("img_login.Image")));
            this.img_login.InitialImage = null;
            this.img_login.Location = new System.Drawing.Point(116, 82);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(475, 146);
            this.img_login.TabIndex = 21;
            this.img_login.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_login);
            this.Controls.Add(this.mnu_principal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnu_principal;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCAD";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.mnu_principal.ResumeLayout(false);
            this.mnu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_principal;
        private System.Windows.Forms.ToolStripMenuItem mnu_cadastro;
        private System.Windows.Forms.ToolStripMenuItem mnu_funcionario;
        private System.Windows.Forms.ToolStripMenuItem mnu_func_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem mnu_cargo;
        private System.Windows.Forms.ToolStripMenuItem mnu_cargo_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem mnu_cargo_consultar;
        private System.Windows.Forms.ToolStripMenuItem mnu_opcao;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.ToolStripMenuItem mnu_usuario;
        private System.Windows.Forms.ToolStripMenuItem mnu_usu_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem mnu_opcao_usuario;
        private System.Windows.Forms.ToolStripMenuItem mnu_opcao_sair;
        private System.Windows.Forms.ToolStripMenuItem mnu_cliente;
        private System.Windows.Forms.ToolStripMenuItem mnu_cli_cadastrar;
    }
}
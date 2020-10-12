using System;

namespace DesktopPonto
{
    partial class F_Principal
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_LISTA = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.ListNames = new System.Windows.Forms.ListBox();
            this.cmdAddLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLougout = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(15, 21);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(157, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_LISTA
            // 
            this.tb_LISTA.Location = new System.Drawing.Point(15, 47);
            this.tb_LISTA.Multiline = true;
            this.tb_LISTA.Name = "tb_LISTA";
            this.tb_LISTA.Size = new System.Drawing.Size(233, 121);
            this.tb_LISTA.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(178, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(70, 20);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(266, 174);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(172, 23);
            this.btn_remover.TabIndex = 6;
            this.btn_remover.Text = "REMOVE";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(13, 5);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(125, 13);
            this.lb_nome.TabIndex = 7;
            this.lb_nome.Text = "adicione o nome abaixo: ";
            this.lb_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListNames
            // 
            this.ListNames.FormattingEnabled = true;
            this.ListNames.Location = new System.Drawing.Point(266, 47);
            this.ListNames.Name = "ListNames";
            this.ListNames.Size = new System.Drawing.Size(172, 121);
            this.ListNames.TabIndex = 8;
            // 
            // cmdAddLista
            // 
            this.cmdAddLista.Location = new System.Drawing.Point(266, 20);
            this.cmdAddLista.Name = "cmdAddLista";
            this.cmdAddLista.Size = new System.Drawing.Size(70, 20);
            this.cmdAddLista.TabIndex = 9;
            this.cmdAddLista.Text = "ADD LIST";
            this.cmdAddLista.UseVisualStyleBackColor = true;
            this.cmdAddLista.Click += new System.EventHandler(this.cmdAddLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(32, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 52);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLougout
            // 
            this.btnLougout.Location = new System.Drawing.Point(163, 315);
            this.btnLougout.Name = "btnLougout";
            this.btnLougout.Size = new System.Drawing.Size(125, 52);
            this.btnLougout.TabIndex = 13;
            this.btnLougout.Text = "Logout";
            this.btnLougout.UseVisualStyleBackColor = true;
            this.btnLougout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Enabled = false;
            this.btnInformacoes.Location = new System.Drawing.Point(32, 373);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(256, 39);
            this.btnInformacoes.TabIndex = 14;
            this.btnInformacoes.Text = "Informações";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(98, 272);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(189, 20);
            this.txtSenha.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 241);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 442);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.btnLougout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAddLista);
            this.Controls.Add(this.ListNames);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_LISTA);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_LISTA;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.ListBox ListNames;
        private System.Windows.Forms.Button cmdAddLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLougout;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}


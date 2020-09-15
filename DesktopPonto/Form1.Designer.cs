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
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 228);
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
    }
}


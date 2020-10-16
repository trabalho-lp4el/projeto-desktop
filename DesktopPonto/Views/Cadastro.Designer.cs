namespace DesktopPonto.Views
{
    partial class CadastreSe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastreSe));
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLogin
            // 
            resources.ApplyResources(this.txbLogin, "txbLogin");
            this.txbLogin.Name = "txbLogin";
            // 
            // BtnCadastrar
            // 
            resources.ApplyResources(this.BtnCadastrar, "BtnCadastrar");
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // lblLogin
            // 
            resources.ApplyResources(this.lblLogin, "lblLogin");
            this.lblLogin.Name = "lblLogin";
            // 
            // txbConfirmarSenha
            // 
            resources.ApplyResources(this.txbConfirmarSenha, "txbConfirmarSenha");
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            // 
            // lblConfirmarSenha
            // 
            resources.ApplyResources(this.lblConfirmarSenha, "lblConfirmarSenha");
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSenha
            // 
            resources.ApplyResources(this.txbSenha, "txbSenha");
            this.txbSenha.Name = "txbSenha";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // CadastreSe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}
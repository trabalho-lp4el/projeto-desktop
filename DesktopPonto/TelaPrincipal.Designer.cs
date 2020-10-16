namespace DesktopPonto
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnAddAusencia = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCurrentHour = new System.Windows.Forms.Label();
            this.flPontos = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAusencia
            // 
            this.btnAddAusencia.Location = new System.Drawing.Point(2, 415);
            this.btnAddAusencia.Name = "btnAddAusencia";
            this.btnAddAusencia.Size = new System.Drawing.Size(209, 23);
            this.btnAddAusencia.TabIndex = 1;
            this.btnAddAusencia.Text = "Adicionar Ausência";
            this.btnAddAusencia.UseVisualStyleBackColor = true;
            this.btnAddAusencia.Click += new System.EventHandler(this.btnAddAusencia_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCurrentDate);
            this.groupBox5.Controls.Add(this.lblNomeUsuario);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.btnAdicionar);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(229, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 393);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(6, 364);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentDate.TabIndex = 4;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(6, 341);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblNomeUsuario.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(103, 79);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(207, 45);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCurrentHour);
            this.groupBox6.Location = new System.Drawing.Point(103, 130);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 183);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // lblCurrentHour
            // 
            this.lblCurrentHour.AutoSize = true;
            this.lblCurrentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHour.Location = new System.Drawing.Point(44, 68);
            this.lblCurrentHour.Name = "lblCurrentHour";
            this.lblCurrentHour.Size = new System.Drawing.Size(0, 46);
            this.lblCurrentHour.TabIndex = 0;
            // 
            // flPontos
            // 
            this.flPontos.AutoScroll = true;
            this.flPontos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPontos.Location = new System.Drawing.Point(2, 12);
            this.flPontos.Name = "flPontos";
            this.flPontos.Size = new System.Drawing.Size(209, 397);
            this.flPontos.TabIndex = 3;
            this.flPontos.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.flPontos);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAddAusencia);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddAusencia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblCurrentHour;
        private System.Windows.Forms.FlowLayoutPanel flPontos;
        private System.Windows.Forms.Timer timer1;
    }
}
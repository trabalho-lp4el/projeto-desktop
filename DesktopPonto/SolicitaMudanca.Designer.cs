namespace DesktopPonto
{
    partial class SolicitaMudanca
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
            this.lblDataPonto = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtHorario = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataPonto
            // 
            this.lblDataPonto.AutoSize = true;
            this.lblDataPonto.Location = new System.Drawing.Point(33, 107);
            this.lblDataPonto.Name = "lblDataPonto";
            this.lblDataPonto.Size = new System.Drawing.Size(0, 13);
            this.lblDataPonto.TabIndex = 0;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(238, 102);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 1;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solicitar Ajuste";
            // 
            // mtHorario
            // 
            this.mtHorario.Location = new System.Drawing.Point(149, 63);
            this.mtHorario.Mask = "00:00";
            this.mtHorario.Name = "mtHorario";
            this.mtHorario.Size = new System.Drawing.Size(37, 20);
            this.mtHorario.TabIndex = 4;
            this.mtHorario.ValidatingType = typeof(System.DateTime);
            this.mtHorario.TextChanged += new System.EventHandler(this.mtHorario_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // SolicitaMudanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 143);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.lblDataPonto);
            this.Name = "SolicitaMudanca";
            this.Text = "SolicitaMudanca";
            this.Load += new System.EventHandler(this.SolicitaMudanca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataPonto;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtHorario;
        private System.Windows.Forms.Button btnCancelar;
    }
}
namespace DesktopPonto
{
    partial class AdicionarAusencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataAusencia = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraAusencia = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Ausencia";
            // 
            // txtDataAusencia
            // 
            this.txtDataAusencia.Location = new System.Drawing.Point(61, 83);
            this.txtDataAusencia.Mask = "00/00/0000";
            this.txtDataAusencia.Name = "txtDataAusencia";
            this.txtDataAusencia.Size = new System.Drawing.Size(100, 20);
            this.txtDataAusencia.TabIndex = 1;
            this.txtDataAusencia.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraAusencia
            // 
            this.txtHoraAusencia.Location = new System.Drawing.Point(201, 83);
            this.txtHoraAusencia.Mask = "00:00";
            this.txtHoraAusencia.Name = "txtHoraAusencia";
            this.txtHoraAusencia.Size = new System.Drawing.Size(100, 20);
            this.txtHoraAusencia.TabIndex = 2;
            this.txtHoraAusencia.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Solicitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(145, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AdicionarAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 201);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoraAusencia);
            this.Controls.Add(this.txtDataAusencia);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarAusencia";
            this.Text = "AdicionarAusencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataAusencia;
        private System.Windows.Forms.MaskedTextBox txtHoraAusencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}
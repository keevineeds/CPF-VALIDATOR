namespace ValidadorCPF
{
    partial class Form1
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
            this.txt_visor = new System.Windows.Forms.MaskedTextBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_visor
            // 
            this.txt_visor.Location = new System.Drawing.Point(32, 70);
            this.txt_visor.Mask = "###-###-###-##";
            this.txt_visor.Name = "txt_visor";
            this.txt_visor.Size = new System.Drawing.Size(171, 20);
            this.txt_visor.TabIndex = 0;
            this.txt_visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_visor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(73, 123);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(82, 23);
            this.btn_validar.TabIndex = 1;
            this.btn_validar.Text = "Validar CPF";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 200);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.txt_visor);
            this.Name = "Form1";
            this.Text = "Validador CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_visor;
        private System.Windows.Forms.Button btn_validar;
    }
}


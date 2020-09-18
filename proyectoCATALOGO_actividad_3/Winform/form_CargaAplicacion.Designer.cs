namespace Winform
{
    partial class form_CargaAplicacion
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
            this.pb_Carga = new System.Windows.Forms.ProgressBar();
            this.tm_PantallaCarga = new System.Windows.Forms.Timer(this.components);
            this.lbl_Carga = new System.Windows.Forms.Label();
            this.lbl_Finalizado = new System.Windows.Forms.Label();
            this.btn_CargaPantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb_Carga
            // 
            this.pb_Carga.Location = new System.Drawing.Point(60, 292);
            this.pb_Carga.Name = "pb_Carga";
            this.pb_Carga.Size = new System.Drawing.Size(354, 45);
            this.pb_Carga.TabIndex = 0;
            // 
            // tm_PantallaCarga
            // 
            this.tm_PantallaCarga.Tick += new System.EventHandler(this.tm_PantallaCarga_Tick);
            // 
            // lbl_Carga
            // 
            this.lbl_Carga.AutoSize = true;
            this.lbl_Carga.ForeColor = System.Drawing.Color.White;
            this.lbl_Carga.Location = new System.Drawing.Point(66, 355);
            this.lbl_Carga.Name = "lbl_Carga";
            this.lbl_Carga.Size = new System.Drawing.Size(21, 13);
            this.lbl_Carga.TabIndex = 1;
            this.lbl_Carga.Text = "0%";
            // 
            // lbl_Finalizado
            // 
            this.lbl_Finalizado.AutoSize = true;
            this.lbl_Finalizado.ForeColor = System.Drawing.Color.White;
            this.lbl_Finalizado.Location = new System.Drawing.Point(213, 355);
            this.lbl_Finalizado.Name = "lbl_Finalizado";
            this.lbl_Finalizado.Size = new System.Drawing.Size(51, 13);
            this.lbl_Finalizado.TabIndex = 2;
            this.lbl_Finalizado.Text = "finalizado";
            // 
            // btn_CargaPantalla
            // 
            this.btn_CargaPantalla.Location = new System.Drawing.Point(26, 27);
            this.btn_CargaPantalla.Name = "btn_CargaPantalla";
            this.btn_CargaPantalla.Size = new System.Drawing.Size(82, 44);
            this.btn_CargaPantalla.TabIndex = 3;
            this.btn_CargaPantalla.Text = "button1";
            this.btn_CargaPantalla.UseVisualStyleBackColor = true;
            // 
            // form_CargaAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(475, 399);
            this.Controls.Add(this.btn_CargaPantalla);
            this.Controls.Add(this.lbl_Finalizado);
            this.Controls.Add(this.lbl_Carga);
            this.Controls.Add(this.pb_Carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CargaAplicacion";
            this.Text = "form_CargaAplicacion";
            this.Load += new System.EventHandler(this.form_CargaAplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_Carga;
        private System.Windows.Forms.Timer tm_PantallaCarga;
        private System.Windows.Forms.Label lbl_Carga;
        private System.Windows.Forms.Label lbl_Finalizado;
        private System.Windows.Forms.Button btn_CargaPantalla;
    }
}
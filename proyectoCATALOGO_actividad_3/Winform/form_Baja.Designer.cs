namespace Winform
{
    partial class form_Baja
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
            this.label_avisoBaja = new System.Windows.Forms.Label();
            this.btn_AceptarBaja = new System.Windows.Forms.Button();
            this.btn_CancelarBaja = new System.Windows.Forms.Button();
            this.dgv_Baja = new System.Windows.Forms.DataGridView();
            this.pb_Baja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Baja)).BeginInit();
            this.SuspendLayout();
            // 
            // label_avisoBaja
            // 
            this.label_avisoBaja.AutoSize = true;
            this.label_avisoBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_avisoBaja.Location = new System.Drawing.Point(12, 26);
            this.label_avisoBaja.Name = "label_avisoBaja";
            this.label_avisoBaja.Size = new System.Drawing.Size(323, 20);
            this.label_avisoBaja.TabIndex = 0;
            this.label_avisoBaja.Text = "Esta a punto de eliminar el siguiente articulo:";
            // 
            // btn_AceptarBaja
            // 
            this.btn_AceptarBaja.Location = new System.Drawing.Point(260, 190);
            this.btn_AceptarBaja.Name = "btn_AceptarBaja";
            this.btn_AceptarBaja.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarBaja.TabIndex = 3;
            this.btn_AceptarBaja.Text = "Eliminar";
            this.btn_AceptarBaja.UseVisualStyleBackColor = true;
            this.btn_AceptarBaja.Click += new System.EventHandler(this.btn_AceptarBaja_Click);
            // 
            // btn_CancelarBaja
            // 
            this.btn_CancelarBaja.Location = new System.Drawing.Point(412, 190);
            this.btn_CancelarBaja.Name = "btn_CancelarBaja";
            this.btn_CancelarBaja.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelarBaja.TabIndex = 4;
            this.btn_CancelarBaja.Text = "Cancelar";
            this.btn_CancelarBaja.UseVisualStyleBackColor = true;
            // 
            // dgv_Baja
            // 
            this.dgv_Baja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Baja.Location = new System.Drawing.Point(22, 95);
            this.dgv_Baja.Name = "dgv_Baja";
            this.dgv_Baja.RowHeadersVisible = false;
            this.dgv_Baja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Baja.Size = new System.Drawing.Size(684, 70);
            this.dgv_Baja.TabIndex = 5;
            // 
            // pb_Baja
            // 
            this.pb_Baja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Baja.Location = new System.Drawing.Point(772, 26);
            this.pb_Baja.Name = "pb_Baja";
            this.pb_Baja.Size = new System.Drawing.Size(221, 177);
            this.pb_Baja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Baja.TabIndex = 6;
            this.pb_Baja.TabStop = false;
            // 
            // form_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 275);
            this.Controls.Add(this.pb_Baja);
            this.Controls.Add(this.dgv_Baja);
            this.Controls.Add(this.btn_CancelarBaja);
            this.Controls.Add(this.btn_AceptarBaja);
            this.Controls.Add(this.label_avisoBaja);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "form_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Baja";
            this.Load += new System.EventHandler(this.form_Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Baja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_avisoBaja;
        private System.Windows.Forms.Button btn_AceptarBaja;
        private System.Windows.Forms.Button btn_CancelarBaja;
        private System.Windows.Forms.DataGridView dgv_Baja;
        private System.Windows.Forms.PictureBox pb_Baja;
    }
}
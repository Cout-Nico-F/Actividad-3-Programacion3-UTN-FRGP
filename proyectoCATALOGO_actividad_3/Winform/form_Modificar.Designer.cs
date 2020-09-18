namespace Winform
{
    partial class form_Modificar
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
            this.dgv_Modificar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Modificar
            // 
            this.dgv_Modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Modificar.Location = new System.Drawing.Point(126, 106);
            this.dgv_Modificar.Name = "dgv_Modificar";
            this.dgv_Modificar.Size = new System.Drawing.Size(510, 185);
            this.dgv_Modificar.TabIndex = 0;
            // 
            // form_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.dgv_Modificar);
            this.Name = "form_Modificar";
            this.Text = "form_Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Modificar;
    }
}
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
            this.pb_Baja = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_Baja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baja)).BeginInit();
            this.SuspendLayout();
            // 
            // label_avisoBaja
            // 
            this.label_avisoBaja.AutoSize = true;
            this.label_avisoBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_avisoBaja.Location = new System.Drawing.Point(45, 52);
            this.label_avisoBaja.Name = "label_avisoBaja";
            this.label_avisoBaja.Size = new System.Drawing.Size(291, 17);
            this.label_avisoBaja.TabIndex = 0;
            this.label_avisoBaja.Text = "Esta a punto de eliminar el siguiente articulo:";
            // 
            // pb_Baja
            // 
            this.pb_Baja.Location = new System.Drawing.Point(534, 52);
            this.pb_Baja.Name = "pb_Baja";
            this.pb_Baja.Size = new System.Drawing.Size(286, 237);
            this.pb_Baja.TabIndex = 2;
            this.pb_Baja.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_Baja
            // 
            this.dgv_Baja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Baja.Location = new System.Drawing.Point(39, 96);
            this.dgv_Baja.Name = "dgv_Baja";
            this.dgv_Baja.Size = new System.Drawing.Size(480, 83);
            this.dgv_Baja.TabIndex = 5;
            // 
            // form_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 313);
            this.Controls.Add(this.dgv_Baja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_Baja);
            this.Controls.Add(this.label_avisoBaja);
            this.Name = "form_Baja";
            this.Text = "form_Baja";
            this.Load += new System.EventHandler(this.form_Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_avisoBaja;
        private System.Windows.Forms.PictureBox pb_Baja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_Baja;
    }
}
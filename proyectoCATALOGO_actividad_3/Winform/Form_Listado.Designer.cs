namespace Winform
{
    partial class Form_Listado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListado = new System.Windows.Forms.Label();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.dgv_Listado = new System.Windows.Forms.DataGridView();
            this.btn_VolverListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.White;
            this.lblListado.Location = new System.Drawing.Point(271, 39);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(235, 23);
            this.lblListado.TabIndex = 6;
            this.lblListado.Text = "Listado de Productos";
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Imagen.Location = new System.Drawing.Point(738, 65);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(242, 288);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Imagen.TabIndex = 7;
            this.pb_Imagen.TabStop = false;
            // 
            // dgv_Listado
            // 
            this.dgv_Listado.AllowUserToAddRows = false;
            this.dgv_Listado.AllowUserToDeleteRows = false;
            this.dgv_Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Listado.ColumnHeadersHeight = 35;
            this.dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Listado.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Listado.EnableHeadersVisualStyles = false;
            this.dgv_Listado.GridColor = System.Drawing.Color.SlateGray;
            this.dgv_Listado.Location = new System.Drawing.Point(30, 77);
            this.dgv_Listado.Name = "dgv_Listado";
            this.dgv_Listado.ReadOnly = true;
            this.dgv_Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Listado.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Listado.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Listado.Size = new System.Drawing.Size(675, 276);
            this.dgv_Listado.TabIndex = 8;
            this.dgv_Listado.SelectionChanged += new System.EventHandler(this.dgvListar_SelectionChanged);
            // 
            // btn_VolverListado
            // 
            this.btn_VolverListado.Location = new System.Drawing.Point(30, 12);
            this.btn_VolverListado.Name = "btn_VolverListado";
            this.btn_VolverListado.Size = new System.Drawing.Size(137, 50);
            this.btn_VolverListado.TabIndex = 9;
            this.btn_VolverListado.Text = "Volver";
            this.btn_VolverListado.UseVisualStyleBackColor = true;
            this.btn_VolverListado.Click += new System.EventHandler(this.btn_VolverListado_Click);
            // 
            // Form_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1013, 381);
            this.Controls.Add(this.btn_VolverListado);
            this.Controls.Add(this.dgv_Listado);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.lblListado);
            this.Name = "Form_Listado";
            this.Text = "Form_Listado";
            this.Load += new System.EventHandler(this.Form_Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.DataGridView dgv_Listado;
        private System.Windows.Forms.Button btn_VolverListado;
    }
}
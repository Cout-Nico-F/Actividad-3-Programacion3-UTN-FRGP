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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListado = new System.Windows.Forms.Label();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.dgv_Listado = new System.Windows.Forms.DataGridView();
            this.btn_VolverListado = new System.Windows.Forms.Button();
            this.lbl_Fecha_2 = new System.Windows.Forms.Label();
            this.tm_time = new System.Windows.Forms.Timer(this.components);
            this.lbl_Hora_2 = new System.Windows.Forms.Label();
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
            this.pb_Imagen.Location = new System.Drawing.Point(787, 65);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(225, 288);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Listado.ColumnHeadersHeight = 35;
            this.dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Listado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Listado.EnableHeadersVisualStyles = false;
            this.dgv_Listado.GridColor = System.Drawing.Color.SlateGray;
            this.dgv_Listado.Location = new System.Drawing.Point(30, 77);
            this.dgv_Listado.MultiSelect = false;
            this.dgv_Listado.Name = "dgv_Listado";
            this.dgv_Listado.ReadOnly = true;
            this.dgv_Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Listado.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Listado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Listado.Size = new System.Drawing.Size(738, 286);
            this.dgv_Listado.TabIndex = 8;
            this.dgv_Listado.SelectionChanged += new System.EventHandler(this.dgvListar_SelectionChanged);
            // 
            // btn_VolverListado
            // 
            this.btn_VolverListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolverListado.ForeColor = System.Drawing.Color.White;
            this.btn_VolverListado.Location = new System.Drawing.Point(30, 12);
            this.btn_VolverListado.Name = "btn_VolverListado";
            this.btn_VolverListado.Size = new System.Drawing.Size(137, 50);
            this.btn_VolverListado.TabIndex = 9;
            this.btn_VolverListado.Text = "Volver";
            this.btn_VolverListado.UseVisualStyleBackColor = true;
            this.btn_VolverListado.Click += new System.EventHandler(this.btn_VolverListado_Click);
            // 
            // lbl_Fecha_2
            // 
            this.lbl_Fecha_2.AutoSize = true;
            this.lbl_Fecha_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_2.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha_2.Location = new System.Drawing.Point(447, 379);
            this.lbl_Fecha_2.Name = "lbl_Fecha_2";
            this.lbl_Fecha_2.Size = new System.Drawing.Size(179, 63);
            this.lbl_Fecha_2.TabIndex = 13;
            this.lbl_Fecha_2.Text = "label1";
            // 
            // tm_time
            // 
            this.tm_time.Tick += new System.EventHandler(this.tm_time_Tick);
            // 
            // lbl_Hora_2
            // 
            this.lbl_Hora_2.AutoSize = true;
            this.lbl_Hora_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora_2.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Hora_2.Location = new System.Drawing.Point(156, 379);
            this.lbl_Hora_2.Name = "lbl_Hora_2";
            this.lbl_Hora_2.Size = new System.Drawing.Size(179, 63);
            this.lbl_Hora_2.TabIndex = 14;
            this.lbl_Hora_2.Text = "label1";
            // 
            // Form_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1045, 470);
            this.Controls.Add(this.lbl_Hora_2);
            this.Controls.Add(this.lbl_Fecha_2);
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
        private System.Windows.Forms.Label lbl_Fecha_2;
        private System.Windows.Forms.Timer tm_time;
        private System.Windows.Forms.Label lbl_Hora_2;
    }
}
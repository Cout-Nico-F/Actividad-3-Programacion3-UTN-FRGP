namespace Winform
{
    partial class Form_Bienvenida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Carga = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tm_1 = new System.Windows.Forms.Timer(this.components);
            this.tm_2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Carga = new System.Windows.Forms.Label();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btn_Iniciar);
            this.panel2.Controls.Add(this.lbl_Carga);
            this.panel2.Controls.Add(this.pb_Carga);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 247);
            this.panel2.TabIndex = 1;
            // 
            // pb_Carga
            // 
            this.pb_Carga.ForeColor = System.Drawing.Color.Transparent;
            this.pb_Carga.Location = new System.Drawing.Point(107, 157);
            this.pb_Carga.Name = "pb_Carga";
            this.pb_Carga.Size = new System.Drawing.Size(422, 34);
            this.pb_Carga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola";
            // 
            // tm_1
            // 
            this.tm_1.Interval = 30;
            this.tm_1.Tick += new System.EventHandler(this.tm_1_Tick);
            // 
            // tm_2
            // 
            this.tm_2.Interval = 30;
            this.tm_2.Tick += new System.EventHandler(this.tm_2_Tick);
            // 
            // lbl_Carga
            // 
            this.lbl_Carga.AutoSize = true;
            this.lbl_Carga.Location = new System.Drawing.Point(104, 207);
            this.lbl_Carga.Name = "lbl_Carga";
            this.lbl_Carga.Size = new System.Drawing.Size(35, 13);
            this.lbl_Carga.TabIndex = 2;
            this.lbl_Carga.Text = "label2";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(452, 207);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(51, 21);
            this.btn_Iniciar.TabIndex = 3;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            // 
            // Form_Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Bienvenida";
            this.Text = "Form_Bienvenida";
            this.Load += new System.EventHandler(this.Form_Bienvenida_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tm_1;
        private System.Windows.Forms.Timer tm_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_Carga;
        private System.Windows.Forms.Label lbl_Carga;
        private System.Windows.Forms.Button btn_Iniciar;
    }
}
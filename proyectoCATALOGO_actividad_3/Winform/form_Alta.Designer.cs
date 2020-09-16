namespace Winform
{
  partial class form_Alta
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
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.combob_Marca = new System.Windows.Forms.ComboBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_Categoria = new System.Windows.Forms.Label();
            this.combob_Categoria = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.errorAlta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImagenURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(10, 47);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(59, 14);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descripcion.Location = new System.Drawing.Point(10, 81);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(84, 14);
            this.label_Descripcion.TabIndex = 1;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Marca.Location = new System.Drawing.Point(12, 150);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(47, 14);
            this.lb_Marca.TabIndex = 2;
            this.lb_Marca.Text = "Marca";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(125, 41);
            this.txt_Nombre.MaxLength = 50;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(187, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(125, 75);
            this.txt_Descripcion.MaxLength = 150;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(340, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // combob_Marca
            // 
            this.combob_Marca.FormattingEnabled = true;
            this.combob_Marca.Location = new System.Drawing.Point(125, 143);
            this.combob_Marca.Name = "combob_Marca";
            this.combob_Marca.Size = new System.Drawing.Size(161, 21);
            this.combob_Marca.TabIndex = 5;
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Codigo.Location = new System.Drawing.Point(10, 13);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(52, 14);
            this.label_Codigo.TabIndex = 6;
            this.label_Codigo.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(125, 7);
            this.txt_Codigo.MaxLength = 50;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 1;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(125, 109);
            this.txt_Precio.MaxLength = 15;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 4;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Precio.Location = new System.Drawing.Point(12, 115);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(49, 14);
            this.label_Precio.TabIndex = 9;
            this.label_Precio.Text = "Precio";
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Categoria.Location = new System.Drawing.Point(10, 185);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(71, 14);
            this.label_Categoria.TabIndex = 10;
            this.label_Categoria.Text = "Categoria";
            // 
            // combob_Categoria
            // 
            this.combob_Categoria.FormattingEnabled = true;
            this.combob_Categoria.Location = new System.Drawing.Point(125, 178);
            this.combob_Categoria.Name = "combob_Categoria";
            this.combob_Categoria.Size = new System.Drawing.Size(161, 21);
            this.combob_Categoria.TabIndex = 6;
            // 
            // btAceptar
            // 
            this.btAceptar.BackgroundImage = global::Winform.Properties.Resources.Imagen_Aceptar;
            this.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAceptar.Location = new System.Drawing.Point(339, 265);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(60, 57);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            this.btAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAceptar_MouseMove);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Winform.Properties.Resources.Imagen_Cancelar;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Location = new System.Drawing.Point(416, 265);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(60, 57);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            this.btCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCancelar_MouseMove);
            // 
            // errorAlta
            // 
            this.errorAlta.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Imagen(URL)";
            // 
            // txt_ImagenURL
            // 
            this.txt_ImagenURL.Location = new System.Drawing.Point(125, 215);
            this.txt_ImagenURL.MaxLength = 50;
            this.txt_ImagenURL.Name = "txt_ImagenURL";
            this.txt_ImagenURL.Size = new System.Drawing.Size(340, 20);
            this.txt_ImagenURL.TabIndex = 15;
            // 
            // form_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(518, 348);
            this.Controls.Add(this.txt_ImagenURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.combob_Categoria);
            this.Controls.Add(this.label_Categoria);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label_Codigo);
            this.Controls.Add(this.combob_Marca);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lb_Marca);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_Nombre);
            this.Name = "form_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Arcticulos";
            this.Load += new System.EventHandler(this.form_Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_Nombre;
    private System.Windows.Forms.Label label_Descripcion;
    private System.Windows.Forms.Label lb_Marca;
    private System.Windows.Forms.TextBox txt_Nombre;
    private System.Windows.Forms.TextBox txt_Descripcion;
    private System.Windows.Forms.ComboBox combob_Marca;
    private System.Windows.Forms.Label label_Codigo;
    private System.Windows.Forms.TextBox txt_Codigo;
    private System.Windows.Forms.TextBox txt_Precio;
    private System.Windows.Forms.Label label_Precio;
    private System.Windows.Forms.Label label_Categoria;
    private System.Windows.Forms.ComboBox combob_Categoria;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ErrorProvider errorAlta;
        private System.Windows.Forms.TextBox txt_ImagenURL;
        private System.Windows.Forms.Label label1;
    }
}
namespace Control_Productos_Supermercado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtbPrecioBase = new System.Windows.Forms.TextBox();
            this.txtbProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblSisContProdSuper = new System.Windows.Forms.Label();
            this.dtpFechaVence = new System.Windows.Forms.DateTimePicker();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(427, 145);
            this.lstProductos.MinimumSize = new System.Drawing.Size(405, 173);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(422, 238);
            this.lstProductos.TabIndex = 22;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(314, 417);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(230, 40);
            this.btnAgregarProducto.TabIndex = 21;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtbPrecioBase
            // 
            this.txtbPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbPrecioBase.Location = new System.Drawing.Point(214, 367);
            this.txtbPrecioBase.Name = "txtbPrecioBase";
            this.txtbPrecioBase.Size = new System.Drawing.Size(207, 20);
            this.txtbPrecioBase.TabIndex = 20;
            // 
            // txtbProducto
            // 
            this.txtbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbProducto.Location = new System.Drawing.Point(214, 206);
            this.txtbProducto.Name = "txtbProducto";
            this.txtbProducto.Size = new System.Drawing.Size(207, 20);
            this.txtbProducto.TabIndex = 18;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.Location = new System.Drawing.Point(16, 364);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(110, 24);
            this.lblPrecioBase.TabIndex = 16;
            this.lblPrecioBase.Text = "Precio base";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(16, 201);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 24);
            this.lblProducto.TabIndex = 15;
            this.lblProducto.Text = "Producto";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(16, 151);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 24);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(16, 316);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(198, 24);
            this.lblFechaVencimiento.TabIndex = 13;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblSisContProdSuper
            // 
            this.lblSisContProdSuper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSisContProdSuper.AutoSize = true;
            this.lblSisContProdSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisContProdSuper.Location = new System.Drawing.Point(228, 64);
            this.lblSisContProdSuper.Name = "lblSisContProdSuper";
            this.lblSisContProdSuper.Size = new System.Drawing.Size(436, 24);
            this.lblSisContProdSuper.TabIndex = 12;
            this.lblSisContProdSuper.Text = "Sistema de control de productos en supermercado";
            // 
            // dtpFechaVence
            // 
            this.dtpFechaVence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaVence.CustomFormat = " ";
            this.dtpFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVence.Location = new System.Drawing.Point(221, 316);
            this.dtpFechaVence.Name = "dtpFechaVence";
            this.dtpFechaVence.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVence.TabIndex = 23;
            this.dtpFechaVence.Value = new System.DateTime(2025, 11, 4, 12, 36, 23, 0);
            // 
            // txtbMarca
            // 
            this.txtbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbMarca.Location = new System.Drawing.Point(214, 151);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(207, 20);
            this.txtbMarca.TabIndex = 24;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(16, 263);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(155, 24);
            this.lblTipoProducto.TabIndex = 25;
            this.lblTipoProducto.Text = "Tipo de producto";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "(Seleccione)",
            "Perecedero",
            "No perecedero"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(214, 263);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(207, 21);
            this.cmbTipoProducto.TabIndex = 26;
            this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged);
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.BackColor = System.Drawing.Color.Red;
            this.lblObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio.Location = new System.Drawing.Point(221, 343);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(99, 13);
            this.lblObligatorio.TabIndex = 27;
            this.lblObligatorio.Text = "(OBLIGATORIO)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 469);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.txtbMarca);
            this.Controls.Add(this.dtpFechaVence);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtbPrecioBase);
            this.Controls.Add(this.txtbProducto);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblSisContProdSuper);
            this.MinimumSize = new System.Drawing.Size(877, 438);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtbPrecioBase;
        private System.Windows.Forms.TextBox txtbProducto;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblSisContProdSuper;
        private System.Windows.Forms.DateTimePicker dtpFechaVence;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblObligatorio;
    }
}


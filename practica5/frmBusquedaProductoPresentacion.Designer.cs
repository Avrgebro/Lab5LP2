namespace Vista
{
    partial class frmBusquedaProductoPresentacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.prodPresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prodPresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodPresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prodPresBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProductoPresentacion = new System.Windows.Forms.DataGridView();
            this.prodPresBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prodPresBindingSource2
            // 
            this.prodPresBindingSource2.DataSource = typeof(Modelo.ProdPres);
            // 
            // prodPresBindingSource
            // 
            this.prodPresBindingSource.DataSource = typeof(Modelo.ProdPres);
            // 
            // prodPresBindingSource1
            // 
            this.prodPresBindingSource1.DataSource = typeof(Modelo.ProdPres);
            // 
            // prodPresBindingSource3
            // 
            this.prodPresBindingSource3.DataSource = typeof(Modelo.ProdPres);
            // 
            // dgvProductoPresentacion
            // 
            this.dgvProductoPresentacion.AutoGenerateColumns = false;
            this.dgvProductoPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoPresentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Unidad_Medida,
            this.Precio_Unitario});
            this.dgvProductoPresentacion.DataSource = this.prodPresBindingSource4;
            this.dgvProductoPresentacion.Location = new System.Drawing.Point(12, 50);
            this.dgvProductoPresentacion.Name = "dgvProductoPresentacion";
            this.dgvProductoPresentacion.RowTemplate.Height = 24;
            this.dgvProductoPresentacion.Size = new System.Drawing.Size(700, 277);
            this.dgvProductoPresentacion.TabIndex = 2;
            // 
            // prodPresBindingSource4
            // 
            this.prodPresBindingSource4.DataSource = typeof(Modelo.ProdPres);
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Nombre";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Unidad_Medida
            // 
            this.Unidad_Medida.DataPropertyName = "Unidad";
            this.Unidad_Medida.HeaderText = "Unidad Medida";
            this.Unidad_Medida.Name = "Unidad_Medida";
            this.Unidad_Medida.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.DataPropertyName = "Precio";
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // frmBusquedaProductoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 340);
            this.Controls.Add(this.dgvProductoPresentacion);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBusquedaProductoPresentacion";
            this.Text = "Busqueda Producto Presentación";
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodPresBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource prodPresBindingSource;
        private System.Windows.Forms.BindingSource prodPresBindingSource2;
        private System.Windows.Forms.BindingSource prodPresBindingSource1;
        private System.Windows.Forms.BindingSource prodPresBindingSource3;
        private System.Windows.Forms.DataGridView dgvProductoPresentacion;
        private System.Windows.Forms.BindingSource prodPresBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
    }
}
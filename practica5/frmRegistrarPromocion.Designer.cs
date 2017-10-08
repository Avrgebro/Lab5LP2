namespace Vista
{
    partial class frmRegistrarProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblNombrePromocion = new System.Windows.Forms.Label();
            this.gbPromocion = new System.Windows.Forms.GroupBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.dtpFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtDescripcionPromocion = new System.Windows.Forms.TextBox();
            this.txtNombrePromocion = new System.Windows.Forms.TextBox();
            this.lblDescripcionPromocion = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.dgvDetallePromocion = new System.Windows.Forms.DataGridView();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.detallePromocionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gbPromocion.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePromocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePromocionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.toolStripSeparator,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombrePromocion
            // 
            this.lblNombrePromocion.AutoSize = true;
            this.lblNombrePromocion.Location = new System.Drawing.Point(17, 28);
            this.lblNombrePromocion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePromocion.Name = "lblNombrePromocion";
            this.lblNombrePromocion.Size = new System.Drawing.Size(62, 17);
            this.lblNombrePromocion.TabIndex = 1;
            this.lblNombrePromocion.Text = "Nombre:";
            // 
            // gbPromocion
            // 
            this.gbPromocion.Controls.Add(this.txtCostoTotal);
            this.gbPromocion.Controls.Add(this.lblCostoTotal);
            this.gbPromocion.Controls.Add(this.dtpFechaTermino);
            this.gbPromocion.Controls.Add(this.lblFechaTermino);
            this.gbPromocion.Controls.Add(this.dtpFechaInicio);
            this.gbPromocion.Controls.Add(this.lblFechaInicio);
            this.gbPromocion.Controls.Add(this.txtDescripcionPromocion);
            this.gbPromocion.Controls.Add(this.txtNombrePromocion);
            this.gbPromocion.Controls.Add(this.lblDescripcionPromocion);
            this.gbPromocion.Controls.Add(this.lblNombrePromocion);
            this.gbPromocion.Location = new System.Drawing.Point(16, 34);
            this.gbPromocion.Margin = new System.Windows.Forms.Padding(4);
            this.gbPromocion.Name = "gbPromocion";
            this.gbPromocion.Padding = new System.Windows.Forms.Padding(4);
            this.gbPromocion.Size = new System.Drawing.Size(759, 151);
            this.gbPromocion.TabIndex = 2;
            this.gbPromocion.TabStop = false;
            this.gbPromocion.Text = "Promoción";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(476, 96);
            this.txtCostoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(125, 22);
            this.txtCostoTotal.TabIndex = 5;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(361, 100);
            this.lblCostoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(84, 17);
            this.lblCostoTotal.TabIndex = 9;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // dtpFechaTermino
            // 
            this.dtpFechaTermino.Location = new System.Drawing.Point(476, 59);
            this.dtpFechaTermino.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaTermino.Name = "dtpFechaTermino";
            this.dtpFechaTermino.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaTermino.TabIndex = 4;
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(360, 63);
            this.lblFechaTermino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(107, 17);
            this.lblFechaTermino.TabIndex = 7;
            this.lblFechaTermino.Text = "Fecha Término:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(476, 25);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(360, 28);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // txtDescripcionPromocion
            // 
            this.txtDescripcionPromocion.Location = new System.Drawing.Point(116, 59);
            this.txtDescripcionPromocion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionPromocion.Multiline = true;
            this.txtDescripcionPromocion.Name = "txtDescripcionPromocion";
            this.txtDescripcionPromocion.Size = new System.Drawing.Size(213, 77);
            this.txtDescripcionPromocion.TabIndex = 2;
            // 
            // txtNombrePromocion
            // 
            this.txtNombrePromocion.Location = new System.Drawing.Point(116, 25);
            this.txtNombrePromocion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePromocion.Name = "txtNombrePromocion";
            this.txtNombrePromocion.Size = new System.Drawing.Size(213, 22);
            this.txtNombrePromocion.TabIndex = 1;
            // 
            // lblDescripcionPromocion
            // 
            this.lblDescripcionPromocion.AutoSize = true;
            this.lblDescripcionPromocion.Location = new System.Drawing.Point(17, 63);
            this.lblDescripcionPromocion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionPromocion.Name = "lblDescripcionPromocion";
            this.lblDescripcionPromocion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionPromocion.TabIndex = 2;
            this.lblDescripcionPromocion.Text = "Descripcion:";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnBuscarProducto);
            this.gbProductos.Controls.Add(this.txtCantidad);
            this.gbProductos.Controls.Add(this.btnEliminar);
            this.gbProductos.Controls.Add(this.btnModificar);
            this.gbProductos.Controls.Add(this.btnAgregar);
            this.gbProductos.Controls.Add(this.txtUnidadMedida);
            this.gbProductos.Controls.Add(this.txtStock);
            this.gbProductos.Controls.Add(this.txtCostoUnitario);
            this.gbProductos.Controls.Add(this.lblCantidad);
            this.gbProductos.Controls.Add(this.lblUnidadMedida);
            this.gbProductos.Controls.Add(this.lblStock);
            this.gbProductos.Controls.Add(this.lblCostoUnitario);
            this.gbProductos.Controls.Add(this.dgvDetallePromocion);
            this.gbProductos.Controls.Add(this.txtDescripcionProducto);
            this.gbProductos.Controls.Add(this.txtNombreProducto);
            this.gbProductos.Controls.Add(this.lblDescripcionProducto);
            this.gbProductos.Controls.Add(this.lblNombreProducto);
            this.gbProductos.Controls.Add(this.txtIdProducto);
            this.gbProductos.Controls.Add(this.lblId);
            this.gbProductos.Location = new System.Drawing.Point(16, 193);
            this.gbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Padding = new System.Windows.Forms.Padding(4);
            this.gbProductos.Size = new System.Drawing.Size(759, 318);
            this.gbProductos.TabIndex = 3;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(197, 16);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(51, 28);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(476, 118);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 22);
            this.txtCantidad.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(625, 116);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 28);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(625, 80);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 28);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(625, 43);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 28);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnidadMedida.Location = new System.Drawing.Point(476, 84);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(125, 22);
            this.txtUnidadMedida.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.Location = new System.Drawing.Point(476, 52);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(125, 22);
            this.txtStock.TabIndex = 10;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.SystemColors.Control;
            this.txtCostoUnitario.Location = new System.Drawing.Point(476, 18);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(125, 22);
            this.txtCostoUnitario.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(367, 122);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 17);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(367, 86);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(95, 17);
            this.lblUnidadMedida.TabIndex = 9;
            this.lblUnidadMedida.Text = "Unid. Medida:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(367, 55);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 17);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Location = new System.Drawing.Point(367, 22);
            this.lblCostoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(101, 17);
            this.lblCostoUnitario.TabIndex = 7;
            this.lblCostoUnitario.Text = "Costo Unitario:";
            // 
            // dgvDetallePromocion
            // 
            this.dgvDetallePromocion.AllowUserToAddRows = false;
            this.dgvDetallePromocion.AllowUserToDeleteRows = false;
            this.dgvDetallePromocion.AutoGenerateColumns = false;
            this.dgvDetallePromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CostoUnitario,
            this.UnidadMedida,
            this.Cantidad});
            this.dgvDetallePromocion.DataSource = this.detallePromocionBindingSource;
            this.dgvDetallePromocion.Location = new System.Drawing.Point(21, 164);
            this.dgvDetallePromocion.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallePromocion.Name = "dgvDetallePromocion";
            this.dgvDetallePromocion.ReadOnly = true;
            this.dgvDetallePromocion.Size = new System.Drawing.Size(721, 142);
            this.dgvDetallePromocion.TabIndex = 6;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(116, 82);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(228, 70);
            this.txtDescripcionProducto.TabIndex = 8;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProducto.Location = new System.Drawing.Point(116, 50);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(228, 22);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(17, 86);
            this.lblDescripcionProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionProducto.TabIndex = 3;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(17, 55);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProducto.Location = new System.Drawing.Point(116, 18);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(72, 22);
            this.txtIdProducto.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 22);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // detallePromocionBindingSource
            // 
            this.detallePromocionBindingSource.DataSource = typeof(Modelo.DetallePromocion);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.DataPropertyName = "Costou";
            this.CostoUnitario.HeaderText = "Costo Unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "Unidad";
            this.UnidadMedida.HeaderText = "Unidad Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 140;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 526);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbPromocion);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarProducto";
            this.Text = "Registro de Promoción";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbPromocion.ResumeLayout(false);
            this.gbPromocion.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePromocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePromocionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblNombrePromocion;
        private System.Windows.Forms.GroupBox gbPromocion;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaTermino;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcionPromocion;
        private System.Windows.Forms.TextBox txtNombrePromocion;
        private System.Windows.Forms.Label lblDescripcionPromocion;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.DataGridView dgvDetallePromocion;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.BindingSource detallePromocionBindingSource;
    }
}


namespace CineCHwf
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabBoleto = new System.Windows.Forms.TabPage();
            this.btnVerBoletos = new System.Windows.Forms.Button();
            this.btnEditarBoleto = new System.Windows.Forms.Button();
            this.btnAgrergarBoleto = new System.Windows.Forms.Button();
            this.chkStatusBoleto = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBoletos = new System.Windows.Forms.DataGridView();
            this.txtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.tabPago = new System.Windows.Forms.TabPage();
            this.btnVerPagos = new System.Windows.Forms.Button();
            this.btnEditarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.chkPagoActivo = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdClientePago = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.btnVerReservas = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.chkStatusReserva = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdClienteReserva = new System.Windows.Forms.TextBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tabPromocion = new System.Windows.Forms.TabPage();
            this.dgvPromociones = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.chkStatusPromocion = new System.Windows.Forms.CheckBox();
            this.btnAgregarPromocion = new System.Windows.Forms.Button();
            this.btnEditarPromocion = new System.Windows.Forms.Button();
            this.btnVerPromocion = new System.Windows.Forms.Button();
            this.tabProveedor = new System.Windows.Forms.TabPage();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chkStatusProveedor = new System.Windows.Forms.CheckBox();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.tabRegistroVentas = new System.Windows.Forms.TabPage();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtIdClienteVenta = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtIdPagoVenta = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.chkVentaActiva = new System.Windows.Forms.CheckBox();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnEditarVenta = new System.Windows.Forms.Button();
            this.btnVerVenta = new System.Windows.Forms.Button();
            this.tabFactura = new System.Windows.Forms.TabPage();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.txtIdRegistroVentas = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtClienteEmisor = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.chkFacturaActiva = new System.Windows.Forms.CheckBox();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.btnEditarFactura = new System.Windows.Forms.Button();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.chkProductoActivo = new System.Windows.Forms.CheckBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.tabTipoBoleto = new System.Windows.Forms.TabPage();
            this.dgvTipoBoleto = new System.Windows.Forms.DataGridView();
            this.txtDescripcionTipoBoleto = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.chkStatusTipoBoleto = new System.Windows.Forms.CheckBox();
            this.btnAgregarTipoBoleto = new System.Windows.Forms.Button();
            this.btnEditarTipoBoleto = new System.Windows.Forms.Button();
            this.btnVerTiposBoletos = new System.Windows.Forms.Button();
            this.txtIdTipoBoleto = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabBoleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).BeginInit();
            this.tabPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tabReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tabPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).BeginInit();
            this.tabProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.tabRegistroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabTipoBoleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoBoleto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabBoleto);
            this.tabControl1.Controls.Add(this.tabPago);
            this.tabControl1.Controls.Add(this.tabReserva);
            this.tabControl1.Controls.Add(this.tabPromocion);
            this.tabControl1.Controls.Add(this.tabProveedor);
            this.tabControl1.Controls.Add(this.tabRegistroVentas);
            this.tabControl1.Controls.Add(this.tabFactura);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabTipoBoleto);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.lblError);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(767, 399);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblError.Location = new System.Drawing.Point(337, 295);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(239, 23);
            this.lblError.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(589, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(349, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(349, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.chkStatus);
            this.tabCliente.Controls.Add(this.btnVer);
            this.tabCliente.Controls.Add(this.btnEditar);
            this.tabCliente.Controls.Add(this.btnAgregar);
            this.tabCliente.Controls.Add(this.label7);
            this.tabCliente.Controls.Add(this.txtEmail);
            this.tabCliente.Controls.Add(this.label6);
            this.tabCliente.Controls.Add(this.txtTelefono);
            this.tabCliente.Controls.Add(this.label5);
            this.tabCliente.Controls.Add(this.txtRFC);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.txtApellidos);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.txtNombres);
            this.tabCliente.Controls.Add(this.dgvClientes);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(767, 399);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(103, 255);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 14;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(168, 306);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(103, 356);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(134, 163);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(134, 116);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(132, 20);
            this.txtRFC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(134, 65);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(134, 21);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(132, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(272, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(492, 390);
            this.dgvClientes.TabIndex = 0;
            // 
            // tabBoleto
            // 
            this.tabBoleto.Controls.Add(this.label38);
            this.tabBoleto.Controls.Add(this.txtIdTipoBoleto);
            this.tabBoleto.Controls.Add(this.btnVerBoletos);
            this.tabBoleto.Controls.Add(this.btnEditarBoleto);
            this.tabBoleto.Controls.Add(this.btnAgrergarBoleto);
            this.tabBoleto.Controls.Add(this.chkStatusBoleto);
            this.tabBoleto.Controls.Add(this.label10);
            this.tabBoleto.Controls.Add(this.txtIdCliente);
            this.tabBoleto.Controls.Add(this.label9);
            this.tabBoleto.Controls.Add(this.txtPrecio);
            this.tabBoleto.Controls.Add(this.label8);
            this.tabBoleto.Controls.Add(this.dgvBoletos);
            this.tabBoleto.Controls.Add(this.txtFechaCompra);
            this.tabBoleto.Location = new System.Drawing.Point(4, 22);
            this.tabBoleto.Name = "tabBoleto";
            this.tabBoleto.Size = new System.Drawing.Size(767, 399);
            this.tabBoleto.TabIndex = 2;
            this.tabBoleto.Text = "Boleto";
            this.tabBoleto.UseVisualStyleBackColor = true;
            // 
            // btnVerBoletos
            // 
            this.btnVerBoletos.Location = new System.Drawing.Point(68, 339);
            this.btnVerBoletos.Name = "btnVerBoletos";
            this.btnVerBoletos.Size = new System.Drawing.Size(75, 41);
            this.btnVerBoletos.TabIndex = 10;
            this.btnVerBoletos.Text = "Ver Boletos";
            this.btnVerBoletos.UseVisualStyleBackColor = true;
            this.btnVerBoletos.Click += new System.EventHandler(this.btnVerBoletos_Click);
            // 
            // btnEditarBoleto
            // 
            this.btnEditarBoleto.Location = new System.Drawing.Point(127, 292);
            this.btnEditarBoleto.Name = "btnEditarBoleto";
            this.btnEditarBoleto.Size = new System.Drawing.Size(75, 41);
            this.btnEditarBoleto.TabIndex = 9;
            this.btnEditarBoleto.Text = "Editar Boleto";
            this.btnEditarBoleto.UseVisualStyleBackColor = true;
            this.btnEditarBoleto.Click += new System.EventHandler(this.btnEditarBoleto_Click);
            // 
            // btnAgrergarBoleto
            // 
            this.btnAgrergarBoleto.Location = new System.Drawing.Point(20, 292);
            this.btnAgrergarBoleto.Name = "btnAgrergarBoleto";
            this.btnAgrergarBoleto.Size = new System.Drawing.Size(75, 41);
            this.btnAgrergarBoleto.TabIndex = 8;
            this.btnAgrergarBoleto.Text = "Agregar Boleto";
            this.btnAgrergarBoleto.UseVisualStyleBackColor = true;
            this.btnAgrergarBoleto.Click += new System.EventHandler(this.btnAgrergarBoleto_Click);
            // 
            // chkStatusBoleto
            // 
            this.chkStatusBoleto.AutoSize = true;
            this.chkStatusBoleto.Location = new System.Drawing.Point(69, 250);
            this.chkStatusBoleto.Name = "chkStatusBoleto";
            this.chkStatusBoleto.Size = new System.Drawing.Size(56, 17);
            this.chkStatusBoleto.TabIndex = 7;
            this.chkStatusBoleto.Text = "Status";
            this.chkStatusBoleto.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cliente que compró (Id)";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(51, 153);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(119, 20);
            this.txtIdCliente.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(51, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fecha de Compra";
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.AllowUserToDeleteRows = false;
            this.dgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletos.Location = new System.Drawing.Point(242, 3);
            this.dgvBoletos.Name = "dgvBoletos";
            this.dgvBoletos.Size = new System.Drawing.Size(522, 393);
            this.dgvBoletos.TabIndex = 1;
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(20, 43);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.txtFechaCompra.TabIndex = 0;
            // 
            // tabPago
            // 
            this.tabPago.Controls.Add(this.btnVerPagos);
            this.tabPago.Controls.Add(this.btnEditarPago);
            this.tabPago.Controls.Add(this.btnAgregarPago);
            this.tabPago.Controls.Add(this.chkPagoActivo);
            this.tabPago.Controls.Add(this.label14);
            this.tabPago.Controls.Add(this.dtpFechaPago);
            this.tabPago.Controls.Add(this.label13);
            this.tabPago.Controls.Add(this.txtIdClientePago);
            this.tabPago.Controls.Add(this.label12);
            this.tabPago.Controls.Add(this.txtMetodoPago);
            this.tabPago.Controls.Add(this.label11);
            this.tabPago.Controls.Add(this.txtMonto);
            this.tabPago.Controls.Add(this.dgvPagos);
            this.tabPago.Location = new System.Drawing.Point(4, 22);
            this.tabPago.Name = "tabPago";
            this.tabPago.Padding = new System.Windows.Forms.Padding(3);
            this.tabPago.Size = new System.Drawing.Size(767, 399);
            this.tabPago.TabIndex = 3;
            this.tabPago.Text = "Pago";
            this.tabPago.UseVisualStyleBackColor = true;
            // 
            // btnVerPagos
            // 
            this.btnVerPagos.Location = new System.Drawing.Point(67, 349);
            this.btnVerPagos.Name = "btnVerPagos";
            this.btnVerPagos.Size = new System.Drawing.Size(75, 34);
            this.btnVerPagos.TabIndex = 12;
            this.btnVerPagos.Text = "Ver Pagos";
            this.btnVerPagos.UseVisualStyleBackColor = true;
            this.btnVerPagos.Click += new System.EventHandler(this.btnVerPagos_Click);
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.Location = new System.Drawing.Point(123, 309);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(75, 34);
            this.btnEditarPago.TabIndex = 11;
            this.btnEditarPago.Text = "Editar Pago";
            this.btnEditarPago.UseVisualStyleBackColor = true;
            this.btnEditarPago.Click += new System.EventHandler(this.btnEditarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(17, 309);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(75, 34);
            this.btnAgregarPago.TabIndex = 10;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // chkPagoActivo
            // 
            this.chkPagoActivo.AutoSize = true;
            this.chkPagoActivo.Location = new System.Drawing.Point(86, 276);
            this.chkPagoActivo.Name = "chkPagoActivo";
            this.chkPagoActivo.Size = new System.Drawing.Size(56, 17);
            this.chkPagoActivo.TabIndex = 9;
            this.chkPagoActivo.Text = "Status";
            this.chkPagoActivo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Fecha del Pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(24, 237);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Id del Cliente";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtIdClientePago
            // 
            this.txtIdClientePago.Location = new System.Drawing.Point(98, 164);
            this.txtIdClientePago.Name = "txtIdClientePago";
            this.txtIdClientePago.Size = new System.Drawing.Size(67, 20);
            this.txtIdClientePago.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Método de Pago";
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(98, 101);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(126, 20);
            this.txtMetodoPago.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(98, 46);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(248, 6);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(513, 387);
            this.dgvPagos.TabIndex = 0;
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.btnVerReservas);
            this.tabReserva.Controls.Add(this.btnEditarReserva);
            this.tabReserva.Controls.Add(this.btnAgregarReserva);
            this.tabReserva.Controls.Add(this.chkStatusReserva);
            this.tabReserva.Controls.Add(this.label16);
            this.tabReserva.Controls.Add(this.dtpFechaReserva);
            this.tabReserva.Controls.Add(this.label15);
            this.tabReserva.Controls.Add(this.txtIdClienteReserva);
            this.tabReserva.Controls.Add(this.dgvReservas);
            this.tabReserva.Location = new System.Drawing.Point(4, 22);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Size = new System.Drawing.Size(767, 399);
            this.tabReserva.TabIndex = 4;
            this.tabReserva.Text = "Reserva";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Location = new System.Drawing.Point(55, 315);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(75, 43);
            this.btnVerReservas.TabIndex = 8;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = true;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(112, 253);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(75, 43);
            this.btnEditarReserva.TabIndex = 7;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(17, 253);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(75, 43);
            this.btnAgregarReserva.TabIndex = 6;
            this.btnAgregarReserva.Text = "Agregar Reserva";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            this.btnAgregarReserva.Click += new System.EventHandler(this.btnAgregarReserva_Click);
            // 
            // chkStatusReserva
            // 
            this.chkStatusReserva.AutoSize = true;
            this.chkStatusReserva.Location = new System.Drawing.Point(68, 194);
            this.chkStatusReserva.Name = "chkStatusReserva";
            this.chkStatusReserva.Size = new System.Drawing.Size(56, 17);
            this.chkStatusReserva.TabIndex = 5;
            this.chkStatusReserva.Text = "Status";
            this.chkStatusReserva.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Fecha de Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(6, 132);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Id del Cliente que Reserva";
            // 
            // txtIdClienteReserva
            // 
            this.txtIdClienteReserva.Location = new System.Drawing.Point(68, 61);
            this.txtIdClienteReserva.Name = "txtIdClienteReserva";
            this.txtIdClienteReserva.Size = new System.Drawing.Size(61, 20);
            this.txtIdClienteReserva.TabIndex = 1;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(212, 3);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(552, 393);
            this.dgvReservas.TabIndex = 0;
            // 
            // tabPromocion
            // 
            this.tabPromocion.Controls.Add(this.btnVerPromocion);
            this.tabPromocion.Controls.Add(this.btnEditarPromocion);
            this.tabPromocion.Controls.Add(this.btnAgregarPromocion);
            this.tabPromocion.Controls.Add(this.chkStatusPromocion);
            this.tabPromocion.Controls.Add(this.label20);
            this.tabPromocion.Controls.Add(this.dtpFechaFin);
            this.tabPromocion.Controls.Add(this.label19);
            this.tabPromocion.Controls.Add(this.dtpFechaInicio);
            this.tabPromocion.Controls.Add(this.label18);
            this.tabPromocion.Controls.Add(this.txtDescuento);
            this.tabPromocion.Controls.Add(this.label17);
            this.tabPromocion.Controls.Add(this.txtDescripcion);
            this.tabPromocion.Controls.Add(this.dgvPromociones);
            this.tabPromocion.Location = new System.Drawing.Point(4, 22);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Size = new System.Drawing.Size(767, 399);
            this.tabPromocion.TabIndex = 5;
            this.tabPromocion.Text = "Promoción";
            this.tabPromocion.UseVisualStyleBackColor = true;
            // 
            // dgvPromociones
            // 
            this.dgvPromociones.AllowUserToDeleteRows = false;
            this.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromociones.Location = new System.Drawing.Point(234, 3);
            this.dgvPromociones.Name = "dgvPromociones";
            this.dgvPromociones.Size = new System.Drawing.Size(530, 393);
            this.dgvPromociones.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(26, 54);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(182, 55);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Descripción";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(84, 127);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Descuento $";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(22, 184);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Fecha de Inicio de la Promoción";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(22, 232);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 216);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Fecha de Fin de la Promoción";
            // 
            // chkStatusPromocion
            // 
            this.chkStatusPromocion.AutoSize = true;
            this.chkStatusPromocion.Location = new System.Drawing.Point(84, 265);
            this.chkStatusPromocion.Name = "chkStatusPromocion";
            this.chkStatusPromocion.Size = new System.Drawing.Size(56, 17);
            this.chkStatusPromocion.TabIndex = 9;
            this.chkStatusPromocion.Text = "Status";
            this.chkStatusPromocion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPromocion
            // 
            this.btnAgregarPromocion.Location = new System.Drawing.Point(22, 288);
            this.btnAgregarPromocion.Name = "btnAgregarPromocion";
            this.btnAgregarPromocion.Size = new System.Drawing.Size(83, 51);
            this.btnAgregarPromocion.TabIndex = 10;
            this.btnAgregarPromocion.Text = "Agregar Promocion";
            this.btnAgregarPromocion.UseVisualStyleBackColor = true;
            this.btnAgregarPromocion.Click += new System.EventHandler(this.btnAgregarPromocion_Click);
            // 
            // btnEditarPromocion
            // 
            this.btnEditarPromocion.Location = new System.Drawing.Point(125, 288);
            this.btnEditarPromocion.Name = "btnEditarPromocion";
            this.btnEditarPromocion.Size = new System.Drawing.Size(83, 51);
            this.btnEditarPromocion.TabIndex = 11;
            this.btnEditarPromocion.Text = "Editar Promoción";
            this.btnEditarPromocion.UseVisualStyleBackColor = true;
            this.btnEditarPromocion.Click += new System.EventHandler(this.btnEditarPromocion_Click);
            // 
            // btnVerPromocion
            // 
            this.btnVerPromocion.Location = new System.Drawing.Point(74, 345);
            this.btnVerPromocion.Name = "btnVerPromocion";
            this.btnVerPromocion.Size = new System.Drawing.Size(83, 51);
            this.btnVerPromocion.TabIndex = 12;
            this.btnVerPromocion.Text = "Ver Promoción";
            this.btnVerPromocion.UseVisualStyleBackColor = true;
            this.btnVerPromocion.Click += new System.EventHandler(this.btnVerPromocion_Click);
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.btnVerProveedores);
            this.tabProveedor.Controls.Add(this.btnEditarProveedor);
            this.tabProveedor.Controls.Add(this.btnAgregarProveedor);
            this.tabProveedor.Controls.Add(this.chkStatusProveedor);
            this.tabProveedor.Controls.Add(this.label23);
            this.tabProveedor.Controls.Add(this.txtEmailProveedor);
            this.tabProveedor.Controls.Add(this.label22);
            this.tabProveedor.Controls.Add(this.txtTelefonoProveedor);
            this.tabProveedor.Controls.Add(this.label21);
            this.tabProveedor.Controls.Add(this.txtNombreProveedor);
            this.tabProveedor.Controls.Add(this.dgvProveedores);
            this.tabProveedor.Location = new System.Drawing.Point(4, 22);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Size = new System.Drawing.Size(767, 399);
            this.tabProveedor.TabIndex = 6;
            this.tabProveedor.Text = "Proveedor";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(228, 3);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(536, 393);
            this.dgvProveedores.TabIndex = 0;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(38, 64);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(141, 20);
            this.txtNombreProveedor.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(51, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Nombre del Proveedor";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(120, 111);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(102, 20);
            this.txtTelefonoProveedor.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Telefono del Proveedor";
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.Location = new System.Drawing.Point(38, 169);
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(145, 20);
            this.txtEmailProveedor.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(63, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Email del Proveedor";
            // 
            // chkStatusProveedor
            // 
            this.chkStatusProveedor.AutoSize = true;
            this.chkStatusProveedor.Location = new System.Drawing.Point(66, 231);
            this.chkStatusProveedor.Name = "chkStatusProveedor";
            this.chkStatusProveedor.Size = new System.Drawing.Size(56, 17);
            this.chkStatusProveedor.TabIndex = 7;
            this.chkStatusProveedor.Text = "Status";
            this.chkStatusProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(17, 280);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(83, 51);
            this.btnAgregarProveedor.TabIndex = 8;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Location = new System.Drawing.Point(120, 280);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(83, 51);
            this.btnEditarProveedor.TabIndex = 9;
            this.btnEditarProveedor.Text = "Editar Proveedor";
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.Location = new System.Drawing.Point(66, 337);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(83, 51);
            this.btnVerProveedores.TabIndex = 10;
            this.btnVerProveedores.Text = "Ver Proveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = true;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // tabRegistroVentas
            // 
            this.tabRegistroVentas.Controls.Add(this.btnVerVenta);
            this.tabRegistroVentas.Controls.Add(this.btnEditarVenta);
            this.tabRegistroVentas.Controls.Add(this.btnAgregarVenta);
            this.tabRegistroVentas.Controls.Add(this.chkVentaActiva);
            this.tabRegistroVentas.Controls.Add(this.label28);
            this.tabRegistroVentas.Controls.Add(this.label27);
            this.tabRegistroVentas.Controls.Add(this.dtpFechaVenta);
            this.tabRegistroVentas.Controls.Add(this.label26);
            this.tabRegistroVentas.Controls.Add(this.txtTotalVenta);
            this.tabRegistroVentas.Controls.Add(this.label25);
            this.tabRegistroVentas.Controls.Add(this.txtIdPagoVenta);
            this.tabRegistroVentas.Controls.Add(this.label24);
            this.tabRegistroVentas.Controls.Add(this.txtIdClienteVenta);
            this.tabRegistroVentas.Controls.Add(this.dgvVentas);
            this.tabRegistroVentas.Controls.Add(this.cmbSucursal);
            this.tabRegistroVentas.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroVentas.Name = "tabRegistroVentas";
            this.tabRegistroVentas.Size = new System.Drawing.Size(767, 399);
            this.tabRegistroVentas.TabIndex = 7;
            this.tabRegistroVentas.Text = "Registro de Ventas";
            this.tabRegistroVentas.UseVisualStyleBackColor = true;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(110, 227);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 0;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(237, 3);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(527, 393);
            this.dgvVentas.TabIndex = 1;
            // 
            // txtIdClienteVenta
            // 
            this.txtIdClienteVenta.Location = new System.Drawing.Point(131, 30);
            this.txtIdClienteVenta.Name = "txtIdClienteVenta";
            this.txtIdClienteVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdClienteVenta.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(57, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Id del Cliente";
            // 
            // txtIdPagoVenta
            // 
            this.txtIdPagoVenta.Location = new System.Drawing.Point(131, 77);
            this.txtIdPagoVenta.Name = "txtIdPagoVenta";
            this.txtIdPagoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdPagoVenta.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(57, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Id del Pago";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(131, 125);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVenta.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(37, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Total de la Venta";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(31, 183);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(72, 167);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Fecha de la Venta";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(56, 230);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Sucursal";
            // 
            // chkVentaActiva
            // 
            this.chkVentaActiva.AutoSize = true;
            this.chkVentaActiva.Location = new System.Drawing.Point(60, 266);
            this.chkVentaActiva.Name = "chkVentaActiva";
            this.chkVentaActiva.Size = new System.Drawing.Size(56, 17);
            this.chkVentaActiva.TabIndex = 11;
            this.chkVentaActiva.Text = "Status";
            this.chkVentaActiva.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(3, 289);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(90, 43);
            this.btnAgregarVenta.TabIndex = 12;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnEditarVenta
            // 
            this.btnEditarVenta.Location = new System.Drawing.Point(141, 289);
            this.btnEditarVenta.Name = "btnEditarVenta";
            this.btnEditarVenta.Size = new System.Drawing.Size(90, 43);
            this.btnEditarVenta.TabIndex = 13;
            this.btnEditarVenta.Text = "Editar Venta";
            this.btnEditarVenta.UseVisualStyleBackColor = true;
            this.btnEditarVenta.Click += new System.EventHandler(this.btnEditarVenta_Click);
            // 
            // btnVerVenta
            // 
            this.btnVerVenta.Location = new System.Drawing.Point(75, 353);
            this.btnVerVenta.Name = "btnVerVenta";
            this.btnVerVenta.Size = new System.Drawing.Size(90, 43);
            this.btnVerVenta.TabIndex = 14;
            this.btnVerVenta.Text = "Ver Venta";
            this.btnVerVenta.UseVisualStyleBackColor = true;
            this.btnVerVenta.Click += new System.EventHandler(this.btnVerVenta_Click);
            // 
            // tabFactura
            // 
            this.tabFactura.Controls.Add(this.btnVerFacturas);
            this.tabFactura.Controls.Add(this.btnEditarFactura);
            this.tabFactura.Controls.Add(this.btnAgregarFactura);
            this.tabFactura.Controls.Add(this.chkFacturaActiva);
            this.tabFactura.Controls.Add(this.label33);
            this.tabFactura.Controls.Add(this.dtpFechaFactura);
            this.tabFactura.Controls.Add(this.label32);
            this.tabFactura.Controls.Add(this.txtClienteEmisor);
            this.tabFactura.Controls.Add(this.label31);
            this.tabFactura.Controls.Add(this.txtIVA);
            this.tabFactura.Controls.Add(this.label30);
            this.tabFactura.Controls.Add(this.txtTotalFactura);
            this.tabFactura.Controls.Add(this.label29);
            this.tabFactura.Controls.Add(this.txtIdRegistroVentas);
            this.tabFactura.Controls.Add(this.dgvFacturas);
            this.tabFactura.Location = new System.Drawing.Point(4, 22);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactura.Size = new System.Drawing.Size(767, 399);
            this.tabFactura.TabIndex = 8;
            this.tabFactura.Text = "Factura";
            this.tabFactura.UseVisualStyleBackColor = true;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(227, 6);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(537, 390);
            this.dgvFacturas.TabIndex = 0;
            // 
            // txtIdRegistroVentas
            // 
            this.txtIdRegistroVentas.Location = new System.Drawing.Point(121, 26);
            this.txtIdRegistroVentas.Name = "txtIdRegistroVentas";
            this.txtIdRegistroVentas.Size = new System.Drawing.Size(100, 20);
            this.txtIdRegistroVentas.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 29);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Id Registro de Ventas";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(121, 73);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFactura.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(30, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Total de Factura";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(121, 124);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(91, 131);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(24, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "IVA";
            // 
            // txtClienteEmisor
            // 
            this.txtClienteEmisor.Location = new System.Drawing.Point(121, 172);
            this.txtClienteEmisor.Name = "txtClienteEmisor";
            this.txtClienteEmisor.Size = new System.Drawing.Size(100, 20);
            this.txtClienteEmisor.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(42, 179);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "Cliente Emisor";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(21, 231);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFactura.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(73, 215);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(102, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "Fecha de la Factura";
            // 
            // chkFacturaActiva
            // 
            this.chkFacturaActiva.AutoSize = true;
            this.chkFacturaActiva.Location = new System.Drawing.Point(76, 275);
            this.chkFacturaActiva.Name = "chkFacturaActiva";
            this.chkFacturaActiva.Size = new System.Drawing.Size(56, 17);
            this.chkFacturaActiva.TabIndex = 11;
            this.chkFacturaActiva.Text = "Status";
            this.chkFacturaActiva.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.Location = new System.Drawing.Point(6, 298);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(82, 48);
            this.btnAgregarFactura.TabIndex = 12;
            this.btnAgregarFactura.Text = "Agregar Factura";
            this.btnAgregarFactura.UseVisualStyleBackColor = true;
            this.btnAgregarFactura.Click += new System.EventHandler(this.btnAgregarFactura_Click);
            // 
            // btnEditarFactura
            // 
            this.btnEditarFactura.Location = new System.Drawing.Point(139, 298);
            this.btnEditarFactura.Name = "btnEditarFactura";
            this.btnEditarFactura.Size = new System.Drawing.Size(82, 48);
            this.btnEditarFactura.TabIndex = 13;
            this.btnEditarFactura.Text = "Editar Factura";
            this.btnEditarFactura.UseVisualStyleBackColor = true;
            this.btnEditarFactura.Click += new System.EventHandler(this.btnEditarFactura_Click);
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Location = new System.Drawing.Point(76, 348);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(82, 48);
            this.btnVerFacturas.TabIndex = 14;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.btnVerProductos);
            this.tabProductos.Controls.Add(this.btnEditarProducto);
            this.tabProductos.Controls.Add(this.btnAgregarProducto);
            this.tabProductos.Controls.Add(this.chkProductoActivo);
            this.tabProductos.Controls.Add(this.label36);
            this.tabProductos.Controls.Add(this.txtPrecioProducto);
            this.tabProductos.Controls.Add(this.label35);
            this.tabProductos.Controls.Add(this.txtTipoProducto);
            this.tabProductos.Controls.Add(this.label34);
            this.tabProductos.Controls.Add(this.txtNombreProducto);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(767, 399);
            this.tabProductos.TabIndex = 9;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(223, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(541, 396);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(36, 48);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(126, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(45, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Nombre del Producto";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(36, 112);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(126, 20);
            this.txtTipoProducto.TabIndex = 3;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(54, 96);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 13);
            this.label35.TabIndex = 4;
            this.label35.Text = "Tipo de Producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(36, 175);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioProducto.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(52, 159);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 13);
            this.label36.TabIndex = 6;
            this.label36.Text = "Precio del Producto";
            // 
            // chkProductoActivo
            // 
            this.chkProductoActivo.AutoSize = true;
            this.chkProductoActivo.Location = new System.Drawing.Point(67, 234);
            this.chkProductoActivo.Name = "chkProductoActivo";
            this.chkProductoActivo.Size = new System.Drawing.Size(54, 17);
            this.chkProductoActivo.TabIndex = 7;
            this.chkProductoActivo.Text = "status";
            this.chkProductoActivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(3, 271);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(91, 49);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(126, 271);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(91, 49);
            this.btnEditarProducto.TabIndex = 9;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(67, 326);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(91, 49);
            this.btnVerProductos.TabIndex = 10;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // tabTipoBoleto
            // 
            this.tabTipoBoleto.Controls.Add(this.btnVerTiposBoletos);
            this.tabTipoBoleto.Controls.Add(this.btnEditarTipoBoleto);
            this.tabTipoBoleto.Controls.Add(this.btnAgregarTipoBoleto);
            this.tabTipoBoleto.Controls.Add(this.chkStatusTipoBoleto);
            this.tabTipoBoleto.Controls.Add(this.label37);
            this.tabTipoBoleto.Controls.Add(this.txtDescripcionTipoBoleto);
            this.tabTipoBoleto.Controls.Add(this.dgvTipoBoleto);
            this.tabTipoBoleto.Location = new System.Drawing.Point(4, 22);
            this.tabTipoBoleto.Name = "tabTipoBoleto";
            this.tabTipoBoleto.Size = new System.Drawing.Size(767, 399);
            this.tabTipoBoleto.TabIndex = 10;
            this.tabTipoBoleto.Text = "Tipo de Boleto";
            this.tabTipoBoleto.UseVisualStyleBackColor = true;
            // 
            // dgvTipoBoleto
            // 
            this.dgvTipoBoleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoBoleto.Location = new System.Drawing.Point(235, 3);
            this.dgvTipoBoleto.Name = "dgvTipoBoleto";
            this.dgvTipoBoleto.Size = new System.Drawing.Size(529, 393);
            this.dgvTipoBoleto.TabIndex = 0;
            // 
            // txtDescripcionTipoBoleto
            // 
            this.txtDescripcionTipoBoleto.Location = new System.Drawing.Point(42, 85);
            this.txtDescripcionTipoBoleto.Multiline = true;
            this.txtDescripcionTipoBoleto.Name = "txtDescripcionTipoBoleto";
            this.txtDescripcionTipoBoleto.Size = new System.Drawing.Size(156, 64);
            this.txtDescripcionTipoBoleto.TabIndex = 1;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(39, 69);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(147, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Descripcion del tipo de boleto";
            // 
            // chkStatusTipoBoleto
            // 
            this.chkStatusTipoBoleto.AutoSize = true;
            this.chkStatusTipoBoleto.Location = new System.Drawing.Point(79, 209);
            this.chkStatusTipoBoleto.Name = "chkStatusTipoBoleto";
            this.chkStatusTipoBoleto.Size = new System.Drawing.Size(56, 17);
            this.chkStatusTipoBoleto.TabIndex = 3;
            this.chkStatusTipoBoleto.Text = "Status";
            this.chkStatusTipoBoleto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTipoBoleto
            // 
            this.btnAgregarTipoBoleto.Location = new System.Drawing.Point(4, 257);
            this.btnAgregarTipoBoleto.Name = "btnAgregarTipoBoleto";
            this.btnAgregarTipoBoleto.Size = new System.Drawing.Size(99, 55);
            this.btnAgregarTipoBoleto.TabIndex = 4;
            this.btnAgregarTipoBoleto.Text = "Agregar Tipo de Boleto";
            this.btnAgregarTipoBoleto.UseVisualStyleBackColor = true;
            this.btnAgregarTipoBoleto.Click += new System.EventHandler(this.btnAgregarTipoBoleto_Click);
            // 
            // btnEditarTipoBoleto
            // 
            this.btnEditarTipoBoleto.Location = new System.Drawing.Point(130, 257);
            this.btnEditarTipoBoleto.Name = "btnEditarTipoBoleto";
            this.btnEditarTipoBoleto.Size = new System.Drawing.Size(99, 55);
            this.btnEditarTipoBoleto.TabIndex = 5;
            this.btnEditarTipoBoleto.Text = "Editar Tipo de Boleto";
            this.btnEditarTipoBoleto.UseVisualStyleBackColor = true;
            this.btnEditarTipoBoleto.Click += new System.EventHandler(this.btnEditarTipoBoleto_Click);
            // 
            // btnVerTiposBoletos
            // 
            this.btnVerTiposBoletos.Location = new System.Drawing.Point(63, 318);
            this.btnVerTiposBoletos.Name = "btnVerTiposBoletos";
            this.btnVerTiposBoletos.Size = new System.Drawing.Size(99, 55);
            this.btnVerTiposBoletos.TabIndex = 6;
            this.btnVerTiposBoletos.Text = "Ver Tipos de Boletos";
            this.btnVerTiposBoletos.UseVisualStyleBackColor = true;
            this.btnVerTiposBoletos.Click += new System.EventHandler(this.btnVerTiposBoletos_Click);
            // 
            // txtIdTipoBoleto
            // 
            this.txtIdTipoBoleto.Location = new System.Drawing.Point(68, 202);
            this.txtIdTipoBoleto.Name = "txtIdTipoBoleto";
            this.txtIdTipoBoleto.Size = new System.Drawing.Size(79, 20);
            this.txtIdTipoBoleto.TabIndex = 11;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(67, 186);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(76, 13);
            this.label38.TabIndex = 12;
            this.label38.Text = "Tipo de Boleto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabBoleto.ResumeLayout(false);
            this.tabBoleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).EndInit();
            this.tabPago.ResumeLayout(false);
            this.tabPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tabReserva.ResumeLayout(false);
            this.tabReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tabPromocion.ResumeLayout(false);
            this.tabPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).EndInit();
            this.tabProveedor.ResumeLayout(false);
            this.tabProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.tabRegistroVentas.ResumeLayout(false);
            this.tabRegistroVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabFactura.ResumeLayout(false);
            this.tabFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabTipoBoleto.ResumeLayout(false);
            this.tabTipoBoleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoBoleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TabPage tabBoleto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBoletos;
        private System.Windows.Forms.DateTimePicker txtFechaCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgrergarBoleto;
        private System.Windows.Forms.CheckBox chkStatusBoleto;
        private System.Windows.Forms.Button btnVerBoletos;
        private System.Windows.Forms.Button btnEditarBoleto;
        private System.Windows.Forms.TabPage tabPago;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdClientePago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkPagoActivo;
        private System.Windows.Forms.Button btnVerPagos;
        private System.Windows.Forms.Button btnEditarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdClienteReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnVerReservas;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.CheckBox chkStatusReserva;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.TabPage tabPromocion;
        private System.Windows.Forms.DataGridView dgvPromociones;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.CheckBox chkStatusPromocion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnVerPromocion;
        private System.Windows.Forms.Button btnEditarPromocion;
        private System.Windows.Forms.Button btnAgregarPromocion;
        private System.Windows.Forms.TabPage tabProveedor;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.CheckBox chkStatusProveedor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtEmailProveedor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.TabPage tabRegistroVentas;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIdPagoVenta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtIdClienteVenta;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Button btnVerVenta;
        private System.Windows.Forms.Button btnEditarVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.CheckBox chkVentaActiva;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabFactura;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtIdRegistroVentas;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.CheckBox chkFacturaActiva;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtClienteEmisor;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.Button btnEditarFactura;
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.CheckBox chkProductoActivo;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabTipoBoleto;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtDescripcionTipoBoleto;
        private System.Windows.Forms.DataGridView dgvTipoBoleto;
        private System.Windows.Forms.Button btnVerTiposBoletos;
        private System.Windows.Forms.Button btnEditarTipoBoleto;
        private System.Windows.Forms.Button btnAgregarTipoBoleto;
        private System.Windows.Forms.CheckBox chkStatusTipoBoleto;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtIdTipoBoleto;
    }
}


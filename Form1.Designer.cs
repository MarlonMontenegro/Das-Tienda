namespace Das_Tienda
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CbCategoria = new System.Windows.Forms.ComboBox();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbPrecioProd = new System.Windows.Forms.TextBox();
            this.tbCantidadProd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbNombreProd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListBClientes = new System.Windows.Forms.ListBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tbDirecccionCli = new System.Windows.Forms.TextBox();
            this.TbTelefonoCli = new System.Windows.Forms.TextBox();
            this.tbNombreCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClientesVenta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxProductosVenta = new System.Windows.Forms.ListBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.tbCantidadVenta = new System.Windows.Forms.TextBox();
            this.ProductoSeleccionado = new System.Windows.Forms.Label();
            this.Carrito = new System.Windows.Forms.Label();
            this.listCarrito = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listHistorial = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminarVentaHis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdHistorial = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRealizarVenta);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.listCarrito);
            this.tabPage1.Controls.Add(this.Carrito);
            this.tabPage1.Controls.Add(this.ProductoSeleccionado);
            this.tabPage1.Controls.Add(this.tbCantidadVenta);
            this.tabPage1.Controls.Add(this.CantidadLabel);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listBoxProductosVenta);
            this.tabPage1.Controls.Add(this.cbClientesVenta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CbCategoria);
            this.tabPage2.Controls.Add(this.listBoxProductos);
            this.tabPage2.Controls.Add(this.btnAddProduct);
            this.tabPage2.Controls.Add(this.tbPrecioProd);
            this.tabPage2.Controls.Add(this.tbCantidadProd);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbNombreProd);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CbCategoria
            // 
            this.CbCategoria.FormattingEnabled = true;
            this.CbCategoria.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Electricidad",
            "Accesorios",
            "Ropa"});
            this.CbCategoria.Location = new System.Drawing.Point(80, 80);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(211, 21);
            this.CbCategoria.TabIndex = 50;
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.Location = new System.Drawing.Point(320, 49);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(418, 342);
            this.listBoxProductos.TabIndex = 49;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(23, 143);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(268, 24);
            this.btnAddProduct.TabIndex = 46;
            this.btnAddProduct.Text = "Registrar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // tbPrecioProd
            // 
            this.tbPrecioProd.Location = new System.Drawing.Point(213, 49);
            this.tbPrecioProd.Name = "tbPrecioProd";
            this.tbPrecioProd.Size = new System.Drawing.Size(78, 20);
            this.tbPrecioProd.TabIndex = 45;
            // 
            // tbCantidadProd
            // 
            this.tbCantidadProd.Location = new System.Drawing.Point(80, 108);
            this.tbCantidadProd.Name = "tbCantidadProd";
            this.tbCantidadProd.Size = new System.Drawing.Size(211, 20);
            this.tbCantidadProd.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Cantidad";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(170, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Precio";
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.Location = new System.Drawing.Point(80, 49);
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Size = new System.Drawing.Size(84, 20);
            this.tbNombreProd.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Categoría";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nombre";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Ingresar Producto";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ListBClientes);
            this.tabPage3.Controls.Add(this.btnAddClient);
            this.tabPage3.Controls.Add(this.tbDirecccionCli);
            this.tabPage3.Controls.Add(this.TbTelefonoCli);
            this.tabPage3.Controls.Add(this.tbNombreCli);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ListBClientes
            // 
            this.ListBClientes.FormattingEnabled = true;
            this.ListBClientes.Location = new System.Drawing.Point(326, 46);
            this.ListBClientes.Name = "ListBClientes";
            this.ListBClientes.Size = new System.Drawing.Size(423, 342);
            this.ListBClientes.TabIndex = 35;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(19, 144);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(283, 24);
            this.btnAddClient.TabIndex = 34;
            this.btnAddClient.Text = "Registrar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tbDirecccionCli
            // 
            this.tbDirecccionCli.Location = new System.Drawing.Point(74, 72);
            this.tbDirecccionCli.Name = "tbDirecccionCli";
            this.tbDirecccionCli.Size = new System.Drawing.Size(228, 20);
            this.tbDirecccionCli.TabIndex = 32;
            // 
            // TbTelefonoCli
            // 
            this.TbTelefonoCli.Location = new System.Drawing.Point(74, 106);
            this.TbTelefonoCli.Name = "TbTelefonoCli";
            this.TbTelefonoCli.Size = new System.Drawing.Size(228, 20);
            this.TbTelefonoCli.TabIndex = 33;
            // 
            // tbNombreCli
            // 
            this.tbNombreCli.Location = new System.Drawing.Point(74, 46);
            this.tbNombreCli.Name = "tbNombreCli";
            this.tbNombreCli.Size = new System.Drawing.Size(228, 20);
            this.tbNombreCli.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Dirección ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Registrar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione al Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos";
            // 
            // cbClientesVenta
            // 
            this.cbClientesVenta.FormattingEnabled = true;
            this.cbClientesVenta.Location = new System.Drawing.Point(24, 41);
            this.cbClientesVenta.Name = "cbClientesVenta";
            this.cbClientesVenta.Size = new System.Drawing.Size(121, 21);
            this.cbClientesVenta.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hacer Nuevo pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxProductosVenta
            // 
            this.listBoxProductosVenta.FormattingEnabled = true;
            this.listBoxProductosVenta.Location = new System.Drawing.Point(401, 39);
            this.listBoxProductosVenta.Name = "listBoxProductosVenta";
            this.listBoxProductosVenta.Size = new System.Drawing.Size(344, 121);
            this.listBoxProductosVenta.TabIndex = 3;
            this.listBoxProductosVenta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProductosVenta_MouseDoubleClick);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(21, 151);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.CantidadLabel.TabIndex = 5;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.Visible = false;
            // 
            // tbCantidadVenta
            // 
            this.tbCantidadVenta.Location = new System.Drawing.Point(76, 144);
            this.tbCantidadVenta.Name = "tbCantidadVenta";
            this.tbCantidadVenta.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadVenta.TabIndex = 6;
            this.tbCantidadVenta.Visible = false;
            // 
            // ProductoSeleccionado
            // 
            this.ProductoSeleccionado.AutoSize = true;
            this.ProductoSeleccionado.Location = new System.Drawing.Point(21, 123);
            this.ProductoSeleccionado.Name = "ProductoSeleccionado";
            this.ProductoSeleccionado.Size = new System.Drawing.Size(35, 13);
            this.ProductoSeleccionado.TabIndex = 7;
            this.ProductoSeleccionado.Text = "label3";
            this.ProductoSeleccionado.Visible = false;
            // 
            // Carrito
            // 
            this.Carrito.AutoSize = true;
            this.Carrito.Location = new System.Drawing.Point(398, 192);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(37, 13);
            this.Carrito.TabIndex = 8;
            this.Carrito.Text = "Carrito";
            // 
            // listCarrito
            // 
            this.listCarrito.FormattingEnabled = true;
            this.listCarrito.Location = new System.Drawing.Point(401, 218);
            this.listCarrito.Name = "listCarrito";
            this.listCarrito.Size = new System.Drawing.Size(344, 108);
            this.listCarrito.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 170);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar a Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(401, 333);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(121, 23);
            this.btnRealizarVenta.TabIndex = 11;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbIdHistorial);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.BtnEliminarVentaHis);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.listHistorial);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(767, 408);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historial";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listHistorial
            // 
            this.listHistorial.FormattingEnabled = true;
            this.listHistorial.Location = new System.Drawing.Point(25, 39);
            this.listHistorial.Name = "listHistorial";
            this.listHistorial.Size = new System.Drawing.Size(451, 238);
            this.listHistorial.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Historial de Ventas";
            // 
            // BtnEliminarVentaHis
            // 
            this.BtnEliminarVentaHis.Location = new System.Drawing.Point(25, 336);
            this.BtnEliminarVentaHis.Name = "BtnEliminarVentaHis";
            this.BtnEliminarVentaHis.Size = new System.Drawing.Size(106, 23);
            this.BtnEliminarVentaHis.TabIndex = 2;
            this.BtnEliminarVentaHis.Text = "Eliminar Venta";
            this.BtnEliminarVentaHis.UseVisualStyleBackColor = true;
            this.BtnEliminarVentaHis.Click += new System.EventHandler(this.BtnEliminarVentaHis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese el ID de la venta a eliminar";
            // 
            // tbIdHistorial
            // 
            this.tbIdHistorial.Location = new System.Drawing.Point(28, 310);
            this.tbIdHistorial.Name = "tbIdHistorial";
            this.tbIdHistorial.Size = new System.Drawing.Size(100, 20);
            this.tbIdHistorial.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox ListBClientes;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox tbDirecccionCli;
        private System.Windows.Forms.TextBox TbTelefonoCli;
        private System.Windows.Forms.TextBox tbNombreCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbPrecioProd;
        private System.Windows.Forms.TextBox tbCantidadProd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbNombreProd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.ComboBox CbCategoria;
        private System.Windows.Forms.ComboBox cbClientesVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxProductosVenta;
        private System.Windows.Forms.TextBox tbCantidadVenta;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label ProductoSeleccionado;
        private System.Windows.Forms.ListBox listCarrito;
        private System.Windows.Forms.Label Carrito;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listHistorial;
        private System.Windows.Forms.Button BtnEliminarVentaHis;
        private System.Windows.Forms.TextBox tbIdHistorial;
        private System.Windows.Forms.Label label4;
    }
}


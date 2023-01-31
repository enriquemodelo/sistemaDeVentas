
namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_mantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.submenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.submenuVerDetalleVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_mantenedor,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_acercade});
            this.menu.Location = new System.Drawing.Point(20, 136);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1460, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.IconSize = 50;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(80, 69);
            this.menu_usuario.Text = "Usuario";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_usuario.Click += new System.EventHandler(this.menu_usuario_Click);
            // 
            // menu_mantenedor
            // 
            this.menu_mantenedor.AutoSize = false;
            this.menu_mantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuCategorias,
            this.submenuProducto});
            this.menu_mantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menu_mantenedor.IconColor = System.Drawing.Color.Black;
            this.menu_mantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_mantenedor.IconSize = 50;
            this.menu_mantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_mantenedor.Name = "menu_mantenedor";
            this.menu_mantenedor.Size = new System.Drawing.Size(80, 69);
            this.menu_mantenedor.Text = "Mantenedor";
            this.menu_mantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuCategorias
            // 
            this.submenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuCategorias.IconColor = System.Drawing.Color.Black;
            this.submenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCategorias.Name = "submenuCategorias";
            this.submenuCategorias.Size = new System.Drawing.Size(130, 22);
            this.submenuCategorias.Text = "Categorias";
            this.submenuCategorias.Click += new System.EventHandler(this.submenuCategorias_Click);
            // 
            // submenuProducto
            // 
            this.submenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuProducto.IconColor = System.Drawing.Color.Black;
            this.submenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProducto.Name = "submenuProducto";
            this.submenuProducto.Size = new System.Drawing.Size(130, 22);
            this.submenuProducto.Text = "Producto";
            this.submenuProducto.Click += new System.EventHandler(this.submenuProducto_Click);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarVenta,
            this.submenuVerDetalleVentas});
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.IconSize = 50;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(119, 69);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarVenta
            // 
            this.submenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegistrarVenta.Name = "submenuRegistrarVenta";
            this.submenuRegistrarVenta.Size = new System.Drawing.Size(129, 22);
            this.submenuRegistrarVenta.Text = "Registrar";
            this.submenuRegistrarVenta.Click += new System.EventHandler(this.submenuRegistrarVenta_Click);
            // 
            // submenuVerDetalleVentas
            // 
            this.submenuVerDetalleVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuVerDetalleVentas.IconColor = System.Drawing.Color.Black;
            this.submenuVerDetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuVerDetalleVentas.Name = "submenuVerDetalleVentas";
            this.submenuVerDetalleVentas.Size = new System.Drawing.Size(129, 22);
            this.submenuVerDetalleVentas.Text = "Ver Detalle";
            this.submenuVerDetalleVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submenuVerDetalleVentas.Click += new System.EventHandler(this.submenuVerDetalleVentas_Click);
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarCompra,
            this.submenuVerDetalleCompra});
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.IconSize = 50;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(80, 69);
            this.menu_compras.Text = "Compras";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarCompra
            // 
            this.submenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegistrarCompra.Name = "submenuRegistrarCompra";
            this.submenuRegistrarCompra.Size = new System.Drawing.Size(166, 22);
            this.submenuRegistrarCompra.Text = "Registrar Compra";
            this.submenuRegistrarCompra.Click += new System.EventHandler(this.submenuRegistrarCompra_Click);
            // 
            // submenuVerDetalleCompra
            // 
            this.submenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.submenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuVerDetalleCompra.Name = "submenuVerDetalleCompra";
            this.submenuVerDetalleCompra.Size = new System.Drawing.Size(166, 22);
            this.submenuVerDetalleCompra.Text = "Ver Detalle";
            this.submenuVerDetalleCompra.Click += new System.EventHandler(this.submenuVerDetalleCompra_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 50;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(119, 69);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.menu_clientes_Click);
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedores.IconSize = 50;
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(119, 69);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_proveedores.Click += new System.EventHandler(this.menu_proveedores_Click);
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.IconSize = 50;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(80, 69);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_reportes.Click += new System.EventHandler(this.menu_reportes_Click);
            // 
            // menu_acercade
            // 
            this.menu_acercade.AutoSize = false;
            this.menu_acercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menu_acercade.IconColor = System.Drawing.Color.Black;
            this.menu_acercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acercade.IconSize = 50;
            this.menu_acercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercade.Name = "menu_acercade";
            this.menu_acercade.Size = new System.Drawing.Size(80, 69);
            this.menu_acercade.Text = "Acerca de";
            this.menu_acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(20, 60);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1460, 76);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            this.menutitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menutitulo_ItemClicked);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.HorizontalScrollbarBarColor = true;
            this.contenedor.HorizontalScrollbarHighlightOnWheel = false;
            this.contenedor.HorizontalScrollbarSize = 10;
            this.contenedor.Location = new System.Drawing.Point(20, 209);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1460, 621);
            this.contenedor.TabIndex = 3;
            this.contenedor.VerticalScrollbarBarColor = true;
            this.contenedor.VerticalScrollbarHighlightOnWheel = false;
            this.contenedor.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(962, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(1035, 94);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(79, 21);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem mantenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem ventas;
        private FontAwesome.Sharp.IconMenuItem compras;
        private FontAwesome.Sharp.IconMenuItem clientes;
        private FontAwesome.Sharp.IconMenuItem proveedores;
        private FontAwesome.Sharp.IconMenuItem reportes;
        private FontAwesome.Sharp.IconMenuItem acercade;
        private FontAwesome.Sharp.IconMenuItem menu_mantenedor;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
        private FontAwesome.Sharp.IconMenuItem menu_acercade;
        private MetroFramework.Controls.MetroPanel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenuCategorias;
        private FontAwesome.Sharp.IconMenuItem submenuProducto;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleVentas;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleCompra;
    }
}


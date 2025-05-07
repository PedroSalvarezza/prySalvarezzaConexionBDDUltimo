namespace prySalvarezzaConexionBDD
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.dgvManejo = new System.Windows.Forms.DataGridView();
            this.mrcBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.mrcProductos = new System.Windows.Forms.GroupBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorías = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).BeginInit();
            this.mrcBuscar.SuspendLayout();
            this.mrcProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManejo
            // 
            this.dgvManejo.AllowUserToAddRows = false;
            this.dgvManejo.AllowUserToDeleteRows = false;
            this.dgvManejo.AllowUserToResizeColumns = false;
            this.dgvManejo.AllowUserToResizeRows = false;
            this.dgvManejo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvManejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManejo.Location = new System.Drawing.Point(216, 62);
            this.dgvManejo.MultiSelect = false;
            this.dgvManejo.Name = "dgvManejo";
            this.dgvManejo.ReadOnly = true;
            this.dgvManejo.RowHeadersVisible = false;
            this.dgvManejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManejo.Size = new System.Drawing.Size(607, 372);
            this.dgvManejo.TabIndex = 5;
            this.dgvManejo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManejo_CellClick);
            this.dgvManejo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManejo_CellMouseClick);
            // 
            // mrcBuscar
            // 
            this.mrcBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcBuscar.Controls.Add(this.btnMostrar);
            this.mrcBuscar.Controls.Add(this.btnBuscar);
            this.mrcBuscar.Controls.Add(this.cmbBuscar);
            this.mrcBuscar.Location = new System.Drawing.Point(215, 8);
            this.mrcBuscar.Name = "mrcBuscar";
            this.mrcBuscar.Size = new System.Drawing.Size(318, 47);
            this.mrcBuscar.TabIndex = 4;
            this.mrcBuscar.TabStop = false;
            this.mrcBuscar.Text = "Buscar producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(116, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(5, 18);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(93, 21);
            this.cmbBuscar.TabIndex = 38;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // mrcProductos
            // 
            this.mrcProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcProductos.Controls.Add(this.cmbCategorias);
            this.mrcProductos.Controls.Add(this.lblCategorías);
            this.mrcProductos.Controls.Add(this.lblStock);
            this.mrcProductos.Controls.Add(this.numStock);
            this.mrcProductos.Controls.Add(this.numPrecio);
            this.mrcProductos.Controls.Add(this.lblPrecio);
            this.mrcProductos.Controls.Add(this.lblDescripción);
            this.mrcProductos.Controls.Add(this.txtDescripción);
            this.mrcProductos.Controls.Add(this.lblNombre);
            this.mrcProductos.Controls.Add(this.txtNombre);
            this.mrcProductos.Controls.Add(this.numCodigo);
            this.mrcProductos.Controls.Add(this.lblCódigo);
            this.mrcProductos.Controls.Add(this.btnModificar);
            this.mrcProductos.Controls.Add(this.btnEliminar);
            this.mrcProductos.Controls.Add(this.btnDeshacer);
            this.mrcProductos.Controls.Add(this.btnAgregar);
            this.mrcProductos.Location = new System.Drawing.Point(9, 8);
            this.mrcProductos.Name = "mrcProductos";
            this.mrcProductos.Size = new System.Drawing.Size(200, 426);
            this.mrcProductos.TabIndex = 3;
            this.mrcProductos.TabStop = false;
            this.mrcProductos.Text = "Control Productos";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(8, 258);
            this.cmbCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(187, 21);
            this.cmbCategorias.TabIndex = 36;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // lblCategorías
            // 
            this.lblCategorías.AutoSize = true;
            this.lblCategorías.Location = new System.Drawing.Point(5, 238);
            this.lblCategorías.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorías.Name = "lblCategorías";
            this.lblCategorías.Size = new System.Drawing.Size(62, 13);
            this.lblCategorías.TabIndex = 37;
            this.lblCategorías.Text = "Categorías:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(5, 202);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock:";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(8, 217);
            this.numStock.Margin = new System.Windows.Forms.Padding(2);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(84, 20);
            this.numStock.TabIndex = 34;
            this.numStock.ValueChanged += new System.EventHandler(this.numStock_ValueChanged);
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(8, 178);
            this.numPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(84, 20);
            this.numPrecio.TabIndex = 32;
            this.numPrecio.ValueChanged += new System.EventHandler(this.numPrecio_ValueChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(5, 163);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(5, 97);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(66, 13);
            this.lblDescripción.TabIndex = 31;
            this.lblDescripción.Text = "Descripción:";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(8, 112);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(187, 49);
            this.txtDescripción.TabIndex = 30;
            this.txtDescripción.TextChanged += new System.EventHandler(this.txtDescripción_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 56);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(8, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // numCodigo
            // 
            this.numCodigo.Location = new System.Drawing.Point(8, 31);
            this.numCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(80, 20);
            this.numCodigo.TabIndex = 27;
            this.numCodigo.ValueChanged += new System.EventHandler(this.numCodigo_ValueChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(5, 16);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(43, 13);
            this.lblCódigo.TabIndex = 26;
            this.lblCódigo.Text = "Código:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(105, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(13, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeshacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.BackgroundImage")));
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.Location = new System.Drawing.Point(105, 343);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(79, 43);
            this.btnDeshacer.TabIndex = 1;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(13, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrar.BackgroundImage")));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(214, 16);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 23);
            this.btnMostrar.TabIndex = 39;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySalvarezzaConexionBDD.Properties.Resources.Fondo_carga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 446);
            this.Controls.Add(this.dgvManejo);
            this.Controls.Add(this.mrcBuscar);
            this.Controls.Add(this.mrcProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarga";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).EndInit();
            this.mrcBuscar.ResumeLayout(false);
            this.mrcProductos.ResumeLayout(false);
            this.mrcProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManejo;
        private System.Windows.Forms.GroupBox mrcBuscar;
        private System.Windows.Forms.GroupBox mrcProductos;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategorías;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
    }
}